using System;
using System.Collections.Generic;
using System.Text;

using facde.Elements;

namespace facde
{
    public class FacadeTheater
        

    {
        string dvd = "name Film";
        
        Amplifer amp;
        Tuner tuner;
        Projector projector;
        Screen screen;
        

        public FacadeTheater(Amplifer amp, Tuner tuner, Projector projector,Screen screen)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.projector = projector;
            this.screen = screen;
        }

        public void watchMovie(String movie)
        {
            Console.WriteLine("watchMovies");
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setDvd(dvd);
            amp.setSurroundSound();
        }

        public void endMovie()
        {
            Console.WriteLine("endMovies");            
            screen.up();
            projector.off();
            amp.off();
            
        }
    }
}
