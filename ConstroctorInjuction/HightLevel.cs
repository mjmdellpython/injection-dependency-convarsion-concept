using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstroctorInjuction
{
    public class HightLevel
    {
        private readonly IInjection _inject;

        public HightLevel(IInjection inject)
        {
            _inject = inject;
        }
        //constractor injuction
        public void send()
        {
            _inject.send();
        }

        //method injuction
        public void methodsend(IInjection _injection)
        {
            _injection.send();
        }

        //property injuction
        public IInjection propertyInjuction { get; set; }
        public void propertysend()
        {
            propertyInjuction.send();   
        }







        /*tight version
        LowLevel lv = new LowLevel();
        LowLevel_1 lv1 = new LowLevel_1();  

        public void send_1()
        {
            lv.send();
        }

        public void send_2()
        {
            lv1.send();
        }*/
    }
}