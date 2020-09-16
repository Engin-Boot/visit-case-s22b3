using System;
using System.Collections.Generic;
using System.Linq;
using InputOutputHandler;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Sender
{
    class SenderMain
    {
        static void Main(string[] args)
        {
            string filePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\FootfallSensorData.csv";

            IInputHandler _InputDeviceOfSender = new CSVFileInputOutputProcessor(filePath);
            IOutputHandler _OutputDeviceOfSender = new ConsoleInputOutputProcessor();

            Sender _senderInputOutputDevice = new Sender(_InputDeviceOfSender, _OutputDeviceOfSender);

            List<string> data = _senderInputOutputDevice.ReadInputData();

            _senderInputOutputDevice.WriteOuptutData(data);
        }
    }
}
