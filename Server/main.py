import socket
import hashlib
import threading
import random
import time

s = socket.socket()
print("Socket successfully created")
port = 8080
s.bind(('', port))
print("socket binded to %s" % (port))
s.listen(5)
print ("socket is listening")
server, addr = s.accept()
print('Got connection from', addr)
global ipList
global vis
global sList
global keyList
ipList = []
idRoomList = []
sList = []
keyList = []
vis = [0] * 1000    # room limited

def xor(arr, key):
    ans = b''
    for i in range(len(arr)):
        ans += bytes([arr[i] ^ key[i % len(key)]])
    return ans

def run(server, addr):
    global ipList
    global vis
    roomId = -1
    bitmap = b''

    random.seed(time.time())
    key = b''.join([bytes([random.randint(0, 255)]) for i in range(16)])
    print('key: ', key)
    server.send(key)

    while True:
        try:
            dataComing = server.recvfrom(100000)

            message = xor(dataComing[0], key)
            operate = message[0]

            print(message)
            print(chr(operate))

            if operate == ord('1'):  # Login
                username = message.split(b'\n')[1].decode()
                password = message.split(b'\n')[2].decode()
                print(message)
                hashPass = hashlib.sha256(password.encode()).hexdigest()
                authentication = open('log.txt', 'r').readlines()  # check authentication

                stat = 0
                for i, c in enumerate(authentication):
                    checkUser, checkPass = c.split(' ')
                    print(checkUser, checkPass)
                    if (checkUser.strip() == username and checkPass.strip() == hashPass):
                        print('True Authenticate')
                        server.send(xor(b'True', key))
                        stat = 1
                        break

                if stat == 0:
                    server.send(xor(b'False', key))

            elif operate == ord('2'):  # Signup
                username = message.split(b'\n')[1].decode()
                password = message.split(b'\n')[2].decode()
                hashPass = hashlib.sha256(password.encode()).hexdigest()
                authentication = open('log.txt', 'r').readlines()  # check authentication
                if len(authentication) == 0:
                    log = username + ' ' + hashPass
                else:
                    log = '\n' + username + ' ' + hashPass

                stat = 1
                for i, c in enumerate(authentication):
                    checkUser, checkPass = c.split(' ')
                    if (checkUser == username):
                        print('no')
                        server.send(xor(b'False', key))
                        stat = 0
                        break

                if stat == 1:
                    file = open('log.txt', 'a')
                    file.write(log)
                    file.close()
                    server.send(xor(b'True', key))

            elif operate == ord('3'):  # Create Room
                print(addr[0], addr[1])
                stat = 0
                for ip in ipList:
                    if ip[0] == addr[0] and ip[1] == addr[1]:
                        server.send(xor(b'False', key))
                        stat = 1
                        break

                if stat == 0:
                    id = 0
                    while (vis[id] == 1): id += 1
                    vis[id] = 1
                    roomId = id
                    ipList.append(addr)
                    idRoomList.append(id)
                    sList.append(server)
                    keyList.append(key)
                    server.send(xor(str(roomId).encode(), key))

            elif operate == ord('4'):  # Join Room
                print(message)
                roomId = int(message.split(b'\n')[1])
                ipList.append(addr)
                idRoomList.append(roomId)
                sList.append(server)
                keyList.append(key)
                server.send(xor(b'True', key))

            elif operate == ord('5'):
                print('address:', addr)
                print('ipList: ', ipList)
                print('idRoomList: ', idRoomList)
                chat = b'#' + message[2:-2]
                for i in range(len(ipList)):
                    if idRoomList[i] == roomId and (ipList[i][0] != addr[0] or ipList[i][1] != addr[1]):
                        print(chat)
                        sList[i].send(xor(chat, keyList[i]))

            elif message[:4] == b'\x89PNG':   # Drawing
                print('address:', addr)
                print('ipList: ',ipList)
                print('idRoomList: ',idRoomList)
                bitmap = message
                for i in range(len(ipList)):
                    if idRoomList[i] == roomId and (ipList[i][0] != addr[0] or ipList[i][1] != addr[1]):
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

    s.close()
    s = socket.socket()
    port = 8080
    s.bind(('', port))
    s.listen(5)
    print("socket is listening")
    server, addr = s.accept()
    print('Got connection from', addr)