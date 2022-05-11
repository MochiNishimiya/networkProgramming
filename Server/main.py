import socket
import hashlib

s = socket.socket()
print("Socket successfully created")
port = 8080
s.bind(('', port))
print("socket binded to %s" % (port))
s.listen(5)
print ("socket is listening")
server, addr = s.accept()
print('Got connection from', addr)

while True:
    try:
        dataComing = server.recvfrom(1024)
        message = dataComing[0]
        operate = message[0]

        if operate == ord('1'):      # login
            username = message.split(b'\n')[1].decode()
            password = message.split(b'\n')[2].decode()
            hashPass = hashlib.sha256(password.encode()).hexdigest()
            authentication = open('log.txt', 'r').readlines()  # check authentication
            print(authentication)

            print(username, hashPass)
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
        elif operate == ord('2'):
            username = message.split(b'\n')[1].decode()
            password = message.split(b'\n')[2].decode()
            hashPass = hashlib.sha256(password.encode()).hexdigest()
            authentication = open('log.txt', 'r').readlines()  # check authentication
            if len(authentication) == 0:
                log = username + ' ' + hashPass
            else: log = '\n' + username + ' ' + hashPass

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
    except Exception as e:
        print(e)
        s.close()
        s = socket.socket()
        port = 8080
        s.bind(('', port))
        s.listen(5)
        print("socket is listening")
        server, addr = s.accept()
        print('Got connection from', addr)