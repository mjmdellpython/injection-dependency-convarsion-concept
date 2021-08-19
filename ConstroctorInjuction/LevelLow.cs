using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstroctorInjuction
{
    public class LowLevel:IInjection
    {
        public void send()
        {
            Console.WriteLine("low");
        }
    }

    public class LowLevel_1:IInjection
    {
        public void send()
        {
            Console.WriteLine("low_1");
        }
    }
}

