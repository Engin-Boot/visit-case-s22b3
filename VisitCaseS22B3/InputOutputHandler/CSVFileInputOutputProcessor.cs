using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputHandler
{
   public class CSVFileInputOutputProcessor: IInputHandler, IOutputHandler
    {
        public string _CsvFilePath { get; set; }
        public CSVFileInputOutputProcessor(string filepath)
        {
            this._CsvFilePath = filepath;
        }
        public List<string> ReadInput()
        {

            List<string> _DataReadFromCSVFile = new List<string>();
            try
            {

                using (var reader = new StreamReader(_CsvFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        _DataReadFromCSVFile.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return _DataReadFromCSVFile;
        }

        public void WriteOutput(List<string> data)
        {
            try
            {

                using (var writer = new StreamWriter("average.csv"))
                {
                    for (var i = 0; i < data.Count; i++)
                    {
                        writer.WriteLine(data[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        

    }
    }
}
