import socket
import hashlib
import threading
import random
import time
import csv

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
print("Socket successfully created")
port = 34214
s.bind(('', port))
print("socket binded to %s" % (port))
s.listen(5)
print("socket is listening")
server, addr = s.accept()
print('Got connection from', addr)
global ipList
global vis
global sList
global keyList
global idVal
ipList = []
idRoomList = []
sList = []
keyList = []
vis = [0] * 1000  # room limited
idVal = 0


def xor(arr, key):
    ans = b''
    for i in range(len(arr)):
        ans += bytes([arr[i] ^ key[i % len(key)]])
    return ans


def run(server, addr):
    global ipList
    global vis
    global idVal
    roomId = -1
    bitmap = b''

    random.seed(time.time())
    key = b''.join([bytes([random.randint(0, 255)]) for i in range(16)])
    print('key: ', key)
    server.send(key)

    while True:
        try:
            arrRecv = []
            while 1:
                dataComing = server.recv(2048)
                message = xor(dataComing, key)
                print(message)
                arrRecv.append(message)
                if message[len(message) - 1] == 36:
                    break

            message = b''.join(arrRecv)[:-1]
            operate = message[0]

            print('recv message: ', message)

            if operate == ord('1'):  # Login
                username = message.split(b'\n')[1].decode()
                password = message.split(b'\n')[2].decode()
                hashPass = hashlib.sha256(password.encode()).hexdigest()
                authentication = open('log.csv')  # check authentication
                csv_reader = csv.reader(authentication, delimiter=',')

                stat = 0
                for i, c in enumerate(csv_reader):
                    if len(c) == 0: continue

                    checkUser = c[0]
                    checkPass = c[1]

                    print(checkPass, checkUser)

                    if (checkUser.strip() == username and checkPass.strip() == hashPass):
                        server.send(xor(b'True', key))
                        stat = 1
                        break

                authentication.close()

                if stat == 0:
                    server.send(xor(b'False', key))

            elif operate == ord('2'):  # Signup
                username = message.split(b'\n')[1].decode()
                password = message.split(b'\n')[2].decode()
                hashPass = hashlib.sha256(password.encode()).hexdigest()
                authentication = open('log.csv')  # check authentication
                csv_reader = csv.reader(authentication, delimiter=',')

                stat = 1
                for i, c in enumerate(csv_reader):
                    if len(c) == 0: continue
                    checkUser, checkPass = c[0], c[1]
                    if (checkUser == username):
                        server.send(xor(b'False', key))
                        stat = 0
                        break
                authentication.close()

                if stat == 1:
                    file = open('log.csv', 'a', newline='')
                    k = []
                    k.append(username)
                    k.append(hashPass)
                    csvwriter = csv.writer(file)
                    csvwriter.writerow(k)
                    file.close()
                    server.send(xor(b'True', key))

            elif operate == ord('3'):  # Create Room
                stat = 0
                for ip in ipList:
                    if ip[0] == addr[0] and ip[1] == addr[1]:
                        server.send(xor(b'False', key))
                        stat = 1
                        break

                if stat == 0:
                    roomId = idVal
                    idVal += 1
                    ipList.append(addr)
                    idRoomList.append(id)
                    sList.append(server)
                    keyList.append(key)
                    server.send(xor(str(roomId).encode(), key))

            elif operate == ord('4'):  # Join Room
                roomId = int(message.split(b'\n')[1])
                ipList.append(addr)
                idRoomList.append(roomId)
                sList.append(server)
                keyList.append(key)
                server.send(xor(b'True', key))

            elif operate == ord('5'):
                chat = b'#' + message[2:-1]
                for i in range(len(ipList)):
                    if idRoomList[i] == roomId and (ipList[i][0] != addr[0] or ipList[i][1] != addr[1]):
                        print(chat)
                        sList[i].send(xor(chat, keyList[i]))

            elif message[:4] == b'\x89PNG':  # Drawing
                bitmap = message
                print(message)
                print(addr)
                print(ipList)
                print(keyList)
                for i in range(len(ipList)):
                    if idRoomList[i] == roomId and (ipList[i][0] != addr[0] or ipList[i][1] != addr[1]):
                        print(ipList[i])
                        sList[i].send(xor(bitmap, keyList[i]))

            else:
                print(dataComing)
                print('Not implement')
                break

        except Exception as e:
            print(e, addr)
            break

    for i in range(len(ipList)):
        if (ipList[i] == addr):
            ipList.pop(i)
            idRoomList.pop(i)
            sList.pop(i)
            keyList.pop(i)
            break

    print('Exiting...')


while True:
    t = threading.Thread(target=run, args=(server, addr,))
    t.start()

    server, addr = s.accept()
    print('Got connection from', addr)
