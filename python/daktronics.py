import serial


class Daktronics(object):
    def __init__(self, sport, ser=None):
        if ser != None:
            self.Serial = ser
        else:
            self.Serial = serial.Serial("COM1", 19200)
        self.header = b''
        self.code = b''
        self.rtd = b''
        self.checksum = b''
        self.text = b''
        self.dakSports = {
            'football': {
                'dakSize': [1, 295],
                'Main Clock Time [mm:ss/ss.t]': [1, 5],
                'Main Clock Time [mm:ss.t]': [6, 8],
                'Main Clock/Time Out/TOD [mm:ss/ss.t]': [14, 5],
                'Main Clock/Time Out/TOD [mm:ss.t]': [19, 8],
                'Main Clock =0': [27, 1],
                'Main Clock Stopped': [28, 1],
                'Main Clock/Time Out Horn': [29, 1],
                'Main Clock Horn': [30, 1],
                'Time Out Horn': [31, 1],
                'Time Out Time': [32, 8],
                'Time of Day': [40, 8],
                'Home Team Name': [48, 20],
                'Guest Team Name': [68, 20],
                'Home Team Abbreviation': [88, 10],
                'Guest Team Abbreviation': [98, 10],
                'Home Team Score': [108, 4],
                'Guest Team Score': [112, 4],
                'Home Time Outs Left - Full': [116, 2],
                'Home Time Outs Left - Partial': [118, 2],
                'Home Time Outs Left - Television': [120, 2],
                'Home Time Outs Left - Total': [122, 2],
                'Guest Time Outs Left - Full': [124, 2],
                'Guest Time Outs Left - Partial': [126, 2],
                'Guest Time Outs Left - Television': [128, 2],
                'Guest Time Outs Left - Total': [130, 2],
                'Home Time Out Indicator': [132, 1],
                'Home Time Out Text': [133, 4],
                'Guest Time Out Indicator': [137, 1],
                'Guest Time Out Text': [138, 4],
                'Quarter': [142, 2],
                'Quarter Text': [144, 4],
                'Quarter Description': [148, 12],
                'Internal Relay': [160, 1],
                'Ad Panel / Caption Power': [161, 1],
                'Ad Panel / Caption #1': [162, 1],
                'Ad Panel / Caption #2 ': [163, 1],
                'Ad Panel / Caption #3': [164, 1],
                'Ad Panel / Caption #4': [165, 1],
                'Reserved for Future Use': [166, 35],
                'Play Clock Time': [201, 8],
                'Play Clock Horn': [209, 1],
                'Home Possession Indicator': [210, 1],
                'Home Possession Text': [211, 4],
                'Guest Possession Indicator': [215, 1],
                'Guest Possession Text': [216, 4],
                'Ball On': [220, 2],
                'Down': [222, 3],
                'To Go': [225, 2],
                'Home Score - Period 1': [227, 2],
                'Home Score - Period 2': [229, 2],
                'Home Score - Period 3': [231, 2],
                'Home Score - Period 4': [233, 2],
                'Home Score - Period 5': [235, 2],
                'Home Score - Period 6': [237, 2],
                'Home Score - Period 7': [239, 2],
                'Home Score - Period 8': [241, 2],
                'Home Score - Period 9': [243, 2],
                'Home Score - Current Period': [245, 2],
                'Guest Score - Period 1': [247, 2],
                'Guest Score - Period 2': [249, 2],
                'Guest Score - Period 3': [251, 2],
                'Guest Score - Period 4': [253, 2],
                'Guest Score - Period 5': [255, 2],
                'Guest Score - Period 6': [257, 2],
                'Guest Score - Period 7': [259, 2],
                'Guest Score - Period 8': [261, 2],
                'Guest Score - Period 9': [263, 2],
                'Guest Score - Current Period': [265, 2],
                'Home Rushing Yards': [267, 4],
                'Home Passing Yards': [271, 4],
                'Home Total Yards': [275, 4],
                'Guest Rushing Yards': [279, 4],
                'Guest Passing Yards': [283, 4],
                'Guest Total Yards': [287, 4],
                'Home First Downs': [291, 2],
                'Guest First Downs': [293, 2]
                }
            }
        self.sport = self.dakSports[sport]
        self.dakString = " " * self.sport['dakSize'][1]

    def update(self):
        c = b''
        self.rtd = b''
        while c != b'\x16':
            c = self.Serial.read()
        c = b'\x16'
        while c != b'\x17':
            c = self.Serial.read()
            self.rtd += c

        self.header = self.rtd.partition(b'\x16')[2].partition(b'\x01')[0]
        self.code = self.rtd.partition(b'\x01')[2].partition(b'\x02')[0].partition(b'\x04')[0]
        self.text = self.rtd.partition(b'\x02')[2].partition(b'\x04')[0]
        self.checksum = self.rtd.partition(b'\x04')[2].partition(b'\x17')[0]
        print("binary:",self.header, self.code, self.text, self.checksum)

        code = self.code.decode()
        code = code[-4:]
        text = self.text.decode()
        print("code:",code)
        print("text:",text)
        self.dakString = self.dakString[:int(code)] + text + self.dakString[int(code)+len(text):]

    def __getitem__(self, gikey):
        if gikey in self.sport:
            return self.dakString[self.sport[gikey][0]-1:self.sport[gikey][1]+self.sport[gikey][0]-1]
        return ""


dak = Daktronics("football")
while True:
    dak.update()
    print("--------------------------------------------------------------")
    print(dak['Main Clock Time [mm:ss/ss.t]'])
    print(dak['Home Team Name'], dak['Home Team Score'])
    print(dak['Guest Team Name'], dak['Guest Team Score'])
    print("--------------------------------------------------------------")

