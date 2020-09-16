using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputHandler
{
    public interface IInputHandler
    {
        List<string> ReadInput();


    }
    public interface IOutputHandler
    {
        //List<string> ReadInput();
        void WriteOutput(List<string> data);

    }
}
