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
                    // Do something
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

            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == 23)
                {
                    Debug.WriteLine("ETB at " + (i+1).ToString() + " of " + buffer.Length);
                }

                //Console.Write(buffer[i].ToString() + " ");
            }
            //Console.WriteLine();

            Console.Write(System.Text.Encoding.Default.GetString(buffer, 0, buffer.Length));

            // Just write the ASCII values to the screen
            //string incomingData = sp.ReadExisting();
            //Console.WriteLine(incomingData);
            //Console.WriteLine();
        }
    }
}
