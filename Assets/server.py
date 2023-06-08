import socket

class server:
    # Main Variables
    port = 8000 # Port number of server
    message = "" # Message to send
    sendData = "" # Raw data to send
    client = None # TCP client variable

    # toolStripButton1 -- Open Connection
    @staticmethod
    def open_connection():
        # Attempts to make connection
        text = "SASHASURFACE" #TODO

        print(text)

        try:
            server.client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            server.client.connect((text, server.port))
            # Adds debug to list box and shows message box
            print("Connection made with " + text)
        except:
            print("Connection failed")

    # toolStripButton3 -- Close Connection
    @staticmethod
    def close_connection():
        server.client.close() # Closes socket

        print("Connection terminated")

        # listBox1.Items.Add("Connection terminated") # Adds debug message to list box