using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    class LogClass : IformattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("로그 메세지 : {0}", message);
        }

        public void WriteLog(string format, params object[] args)
        {
            string mesg = string.Format(format, args);
            Console.WriteLine("로그 메세지 : {0}", mesg);
        }
    }
}
