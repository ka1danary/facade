using System;
using System.Collections.Generic;
using System.Text;

namespace facde.Elements
{
    public class Amplifer
    {
        public Amplifer()
        {
            Console.WriteLine("Amphiler");
        }

        public void on()
        {
            Console.WriteLine("Amlifer on");
        }

        public void off()
        {
            Console.WriteLine("Amlifer off");
        }
      
       public void Volume()
        {
            Console.WriteLine("Volume on");
        }

       public void setSurroundSound()
        {
            Console.WriteLine("Surround sound set");
        }

        public string setDvd(string dvd)
        {
            return dvd;
        }


    }
}
