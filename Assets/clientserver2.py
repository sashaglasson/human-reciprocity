import socket
import time

class ClientServer2:
    clientsocket = None
    address = None
    listensocket = socket.socket()  # Creates an instance of socket
    Port = 7759  # Port to host server on
    maxConnections = 999
    IP = "192.168.0.102"  # IP address of local machine
    
    @staticmethod
    def start_server():
        ClientServer2.listensocket.bind(('', ClientServer2.Port))
    
        # Starts server
        
        ClientServer2.listensocket.listen(ClientServer2.maxConnections)
        print("Server started at " + ClientServer2.IP + " on port " + str(ClientServer2.Port))

    # Accepts the incoming connection
    # one for each client
    
    @staticmethod
    def accept_connection():
        ClientServer2.clientsocket, ClientServer2.address = ClientServer2.listensocket.accept()

    @staticmethod
    def listen_for_messages():
        message = ClientServer2.clientsocket.recv(1024).decode()  # Gets the incoming message
        return message