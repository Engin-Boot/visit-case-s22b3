using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputHandler
{
    public class ConsoleInputOutputProcessor: IInputHandler, IOutputHandler
    {
        public ConsoleInputOutputProcessor() { }
        public List<string> ReadInput()
        {

            List<string> _DataReadFromConsole = new List<string>();
            try
            {

                string data = string.Empty;
                while ((data = Console.ReadLine()) != null)
                {
                    _DataReadFromConsole.Add(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return _DataReadFromConsole;
        }

        public void WriteOutput(List<string> data)
        {
            foreach (string d in data)
            {
                Console.WriteLine(d);
            }

        }
    }
}
