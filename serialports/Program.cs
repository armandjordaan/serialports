using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace serialports
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine(Environment.NewLine + "Serial port list:" + Environment.NewLine);

            foreach(string s in ports)
            {
                Console.Write(s + "  ");

                try
                {
                    SerialPort p = new SerialPort(s);
                    p.Open();
                    p.Close();
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("(In use)");
                }
            }
            Console.WriteLine();
        }
    }
}
