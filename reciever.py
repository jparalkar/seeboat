import serial 
connected = False 
ports=['COM5','COM7', 'COM3', 'COM4', 'COM8']
ser = None
for port in ports:
	try: 
		ser = serial.Serial(port, 5000)
		print("found port " + port)
	except:
		print("couldn't find port " + port)
text_file = open("recieverData.txt", 'w')

while 1:
    if ser.inWaiting():
        x=ser.readline()
        print(x)
        text_file.write(x.decode('utf-8'))
        text_file.flush()

## close the serial connection and text file
text_file.close()
ser.close()



