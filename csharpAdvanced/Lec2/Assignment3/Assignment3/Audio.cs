using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Audio : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Audio is playing...");
        }
        public void Stop() 
        {
            Console.WriteLine("Audio is stopped...");
        }
    }
}
