import socket
import hashlib
import threading

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
ipList = []
idRoomList = []
vis = [0] * 1000    # room limited

def run(server, addr):
    global ipList
    global vis
    roomId = -1
    bitmap = b''

    while True:
        try:
            dataComing = server.recvfrom(100000)
            message = dataComing[0]
            operate = message[0]

            if operate == ord('1'):  # Login
                username = message.split(b'\n')[1].decode()
                password = message.split(b'\n')[2].decode()
                hashPass = hashlib.sha256(password.encode()).hexdigest()
                authentication = open('log.txt', 'r').readlines()  # check authentication

                stat = 0
                for i, c in enumerate(authentication):
                    checkUser, checkPass = c.split(' ')
                    print(checkUser, checkPass)
                    if (checkUser.strip() == username and checkPass.strip() == hashPass):
                        server.send(b'True')
                        stat = 1
                        break

                if stat == 0:
                    server.send(b'False')

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
                        server.send(b'False')
                        stat = 0
                        break

                if stat == 1:
                    file = open('log.txt', 'a')
                    file.write(log)
                    file.close()
                    server.send(b'True')

            elif operate == ord('3'):  # Create Room
                print(addr[0], addr[1])
                stat = 0
                for ip in ipList:
                    if ip[0] == addr[0] and ip[1] == addr[1]:
                        server.send(b'False')
                        stat = 1
                        break

                if stat == 0:
                    id = 0
                    while (vis[id] == 1): id += 1
                    vis[id] = 1
                    roomId = id
                    ipList.append(addr)
                    idRoomList.append(id)
                    server.send(str(roomId).encode())

            elif operate == ord('4'):  # Join Room
                roomId = int(message.split(b'\n')[1])
                server.send(b'True')

            elif message[:4] == b'\x89PNG':   # Drawing
                bitmap = message
                for i in range(len(ipList)):
                    if idRoomList[i] == roomId and ipList[i] != addr:
                        port = ipList[i][1]
                        address = ipList[i][0]
                        s0 = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
                        s0.connect((address, port))
                        s0.send(bitmap)
                        s0.close()

            else:
                print(dataComing)
                print('Not implement')
                break

        except Exception as e:
            print(e)
            break

    for i in range(len(ipList)):
        if (ipList[i] == addr):
            ipList.pop(i)
            idRoomList.pop(i)
            break
    if roomId != -1:
        vis[roomId] = 0

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