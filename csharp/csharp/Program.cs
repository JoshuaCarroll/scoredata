using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Diagnostics;

namespace csharp
{
    class Program
    {
        static byte[] currentMessage = new byte[0];
        static string lastMessageText = string.Empty;

        static void Main(string[] args)
        {
            string portName = "COM3";

            SerialPort port = new SerialPort(portName, 19200);
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            port.Open();

            Console.WriteLine("** Press ESC to stop monitoring the serial port ** ");
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Go handle events
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
           
            port.Close();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            int length = sp.BytesToRead;
            byte[] buffer = new byte[length];

            sp.Read(buffer, 0, length);

            // Add this to the full message buffer
            currentMessage = Combine(currentMessage, buffer);

            // The End-of-Transmission Block (ETB) character is at the end of each message,
            //  and is always the last character in a block (on this scoreboard).
            if (buffer[buffer.Length - 1] == 23)
            {
                ProcessMessage(currentMessage);
                currentMessage = new byte[0];
            }
        }

        private static void ProcessMessage(byte[] message)
        {
            int posSTX = 0;
            int posEOT = 0;

            for (int i = 0; i < message.Length; i++)
            {
                switch (message[i])
                {
                    case 22:    // Synchronous Idle (SYN)
                        break;
                    case 1:     // Start of Heading (SOH)
                        break;
                    case 2:     // Start of Text (STX)
                        posSTX = i;
                        break;
                    case 4:     // End of Transmission (EOT)
                        posEOT = i;
                        break;
                    case 23:    // End of Transmission Block (ETB)
                        break;
                    default:
                        break;
                }

                if ((posEOT != 0) && (posSTX != 0))
                {
                    break;
                }
            }

            if (posEOT > posSTX)
            {
                string text = System.Text.Encoding.Default.GetString(message, posSTX + 1, posEOT - posSTX - 1);

                if (text != lastMessageText)
                {
                    lastMessageText = text;

                    // Uncomment to see raw output
                    Console.WriteLine(text + " (" + text.Length.ToString() + ")");

                    if (text.Length == 31)
                    {
                        Console.WriteLine("Main clock: " + text.Substring(0, 5));
                        Console.WriteLine("Main clock: " + text.Substring(5, 8));
                        Console.WriteLine("Main/TO/TOD: " + text.Substring(13, 5));
                        Console.WriteLine("Main/TO/TOD: " + text.Substring(18, 8));
                        Console.WriteLine("Main clock =0: " + text.Substring(26, 1));
                        Console.WriteLine("Main clock Stopped: " + (text.Substring(27, 1) == "s").ToString());
                        Console.WriteLine("Main clock/time out horn enabled: " + (text.Substring(28, 1) == "h").ToString());
                        Console.WriteLine("Main clock horn enabled: " + (text.Substring(29, 1) == "h").ToString());
                        Console.WriteLine("Time out horn enabled: " + (text.Substring(30, 1) == "h").ToString());
                    }
                    else if (text.Length >= 294)
                    {
                        Console.WriteLine("Main clock: " + text.Substring(0, 5));
                        Console.WriteLine("Main clock: " + text.Substring(5, 8));
                        Console.WriteLine("Main/TO/TOD: " + text.Substring(13, 5));
                        Console.WriteLine("Main/TO/TOD: " + text.Substring(18, 8));
                        Console.WriteLine("Main clock =0: " + text.Substring(26, 1));
                        Console.WriteLine("Main clock Stopped: " + (text.Substring(27, 1) == "s").ToString());
                        Console.WriteLine("Main clock/time out horn enabled: " + (text.Substring(28, 1) == "h").ToString());
                        Console.WriteLine("Main clock horn enabled: " + (text.Substring(29, 1) == "h").ToString());
                        Console.WriteLine("Time out horn enabled: " + (text.Substring(30, 1) == "h").ToString());
                        Console.WriteLine("Time out time: " + text.Substring(31, 8));
                        Console.WriteLine("Time of day: " + text.Substring(39, 8));
                        Console.WriteLine("Home team name: " + text.Substring(47, 20));
                        Console.WriteLine("Guest team name: " + text.Substring(67, 20));
                        Console.WriteLine("Home team abbr: " + text.Substring(87, 10));
                        Console.WriteLine("Guest team abbr: " + text.Substring(97, 10));
                        Console.WriteLine("Home team score: " + text.Substring(107, 4));
                        Console.WriteLine("Guest team score: " + text.Substring(111, 4));
                        Console.WriteLine("Home Time Outs Left - Full: " + text.Substring(115, 2));
                        Console.WriteLine("Home Time Outs Left - Partial: " + text.Substring(117, 2));
                        Console.WriteLine("Home Time Outs Left - Television: " + text.Substring(119, 2));
                        Console.WriteLine("Home Time Outs Left - Total: " + text.Substring(121, 2));
                        Console.WriteLine("Guest Time Outs Left - Full: " + text.Substring(123, 2));
                        Console.WriteLine("Guest Time Outs Left - Partial: " + text.Substring(125, 2));
                        Console.WriteLine("Guest Time Outs Left - Television: " + text.Substring(127, 2));
                        Console.WriteLine("Guest Time Outs Left - Total: " + text.Substring(129, 2));
                        Console.WriteLine("Home Time Out Indicator: " + text.Substring(131, 1));
                        Console.WriteLine("Home Time Out Text: " + text.Substring(132, 4));
                        Console.WriteLine("Guest Time Out Indicator: " + text.Substring(136, 1));
                        Console.WriteLine("Guest Time Out Text: " + text.Substring(137, 4));
                        Console.WriteLine("Quarter: " + text.Substring(141, 2));
                        Console.WriteLine("Quarter Text ('1st ', 'OT', 'OT/2'): " + text.Substring(143, 4));
                        Console.WriteLine("Quarter Description ('End of 1st'): " + text.Substring(147, 12));
                        Console.WriteLine("Internal Relay (' ' or 'z', 's', 'h'): " + text.Substring(159, 1));
                        Console.WriteLine("Ad Panel / Caption Power ('c'): " + text.Substring(160, 1));
                        Console.WriteLine("Ad Panel / Caption #1 (' ' or 'c'): " + text.Substring(161, 12));
                        Console.WriteLine("Ad Panel / Caption #2 (' ' or 'c'): " + text.Substring(162, 12));
                        Console.WriteLine("Ad Panel / Caption #3 (' ' or 'c'): " + text.Substring(163, 12));
                        Console.WriteLine("Ad Panel / Caption #4 (' ' or 'c'): " + text.Substring(164, 12));
                        Console.WriteLine("Reserved for Future Use: " + text.Substring(166, 35));
                        Console.WriteLine("Play Clock Time (mm:ss): " + text.Substring(200, 8));
                        Console.WriteLine("Play Clock Horn (' ' or 'h'): " + text.Substring(208, 1));
                        Console.WriteLine("Home Possession Indicator (' ' or '<'): " + text.Substring(209, 1));
                        Console.WriteLine("Home Possession Text (' ' or 'POSS'): " + text.Substring(210, 4));
                        Console.WriteLine("Guest Possession Indicator (' ' or '>'): " + text.Substring(214, 1));
                        Console.WriteLine("Guest Possession Text (' ' or 'POSS': " + text.Substring(215, 4));
                        Console.WriteLine("Ball On: " + text.Substring(219, 2));
                        Console.WriteLine("Down ('1st', '2nd', '3rd', '4th'): " + text.Substring(221, 3));
                        Console.WriteLine("To Go: " + text.Substring(224, 2));
                        Console.WriteLine("Home Score - Period 1: " + text.Substring(226, 2));
                        Console.WriteLine("Home Score - Period 2: " + text.Substring(228, 2));
                        Console.WriteLine("Home Score - Period 3: " + text.Substring(230, 2));
                        Console.WriteLine("Home Score - Period 4: " + text.Substring(232, 2));
                        Console.WriteLine("Home Score - Period 5: " + text.Substring(234, 2));
                        Console.WriteLine("Home Score - Period 6: " + text.Substring(236, 2));
                        Console.WriteLine("Home Score - Period 7: " + text.Substring(238, 2));
                        Console.WriteLine("Home Score - Period 8: " + text.Substring(240, 2));
                        Console.WriteLine("Home Score - Period 9: " + text.Substring(242, 2));
                        Console.WriteLine("Home Score - Current Period: " + text.Substring(244, 2));
                        Console.WriteLine("Guest Score - Period 1: " + text.Substring(246, 2));
                        Console.WriteLine("Guest Score - Period 2: " + text.Substring(248, 2));
                        Console.WriteLine("Guest Score - Period 3: " + text.Substring(250, 2));
                        Console.WriteLine("Guest Score - Period 4: " + text.Substring(252, 2));
                        Console.WriteLine("Guest Score - Period 5: " + text.Substring(254, 2));
                        Console.WriteLine("Guest Score - Period 6: " + text.Substring(256, 2));
                        Console.WriteLine("Guest Score - Period 7: " + text.Substring(258, 2));
                        Console.WriteLine("Guest Score - Period 8: " + text.Substring(260, 2));
                        Console.WriteLine("Guest Score - Period 9: " + text.Substring(262, 2));
                        Console.WriteLine("Guest Score - Current Period: " + text.Substring(264, 2));
                        Console.WriteLine("Home Rushing Yards: " + text.Substring(266, 4));
                        Console.WriteLine("Home Passing Yards: " + text.Substring(270, 4));
                        Console.WriteLine("Home Total Yards: " + text.Substring(274, 4));
                        Console.WriteLine("Guest Rushing Yards: " + text.Substring(278, 4));
                        Console.WriteLine("Guest Passing Yards: " + text.Substring(282, 4));
                        Console.WriteLine("Guest Total Yards: " + text.Substring(286, 4));
                        Console.WriteLine("Home First Downs: " + text.Substring(290, 2));
                        Console.WriteLine("Guest First Downs: " + text.Substring(292, 2));
                    }
                }
            }
        }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
    }
}
