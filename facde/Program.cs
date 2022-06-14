using System;
using facde.Elements;

namespace facde
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifer amp = new Amplifer();
            Tuner tuner = new Tuner();
            Projector projector = new Projector();
            Screen screen = new Screen();


            FacadeTheater facadetheater = new FacadeTheater(amp, tuner,projector, screen);
            facadetheater.watchMovie("Ready for watch film name");
            facadetheater.endMovie();
        }
    }
}
