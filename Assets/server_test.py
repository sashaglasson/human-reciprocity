import socket
import time

class Server:
    def __init__(self):
        self.clientsocket = None
        self.address = None
        self.listensocket = socket.socket()  # Creates an instance of socket
        self.Port = 7760  # Port to host server on
        self.maxConnections = 999
        self.IP = socket.gethostname()  # IP address of local machine

        self.listensocket.bind(('', self.Port))

        # Starts server
        self.listensocket.listen(self.maxConnections)
        print("Server started at " + self.IP + " on port " + str(self.Port))

    # Accepts the incoming connection
    # one for each client
    def accept_connection(self):
        self.clientsocket, self.address = self.listensocket.accept()

    def listen_for_messages(self):
        message = self.clientsocket.recv(1024).decode()  # Gets the incoming message
        return message
  
