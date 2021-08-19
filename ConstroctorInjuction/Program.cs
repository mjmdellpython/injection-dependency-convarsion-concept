using System;

namespace ConstroctorInjuction
{
    class Program
    {
        static void Main(string[] args)
        {
           /* HightLevel h= new HightLevel();
            h.send_1();
            h.send_2();*/

            HightLevel h = new HightLevel();

            h.send();// for constroctor injection

            h.methodsend(new LowLevel_1());//for method injuction
            
            h.propertyInjuction = new LowLevel();//for property injection
            h.propertysend();
        }
    }
}
