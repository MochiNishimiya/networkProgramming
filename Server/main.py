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
ipList = []

def run(server, addr):
    global ipList
    while True:
        try:
            dataComing = server.recvfrom(1024)
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
                    ipList.append(addr)
                    server.send(b'True')


            else:
                print('Not implement')
                exit(1)

        except Exception as e:
            print(e)
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