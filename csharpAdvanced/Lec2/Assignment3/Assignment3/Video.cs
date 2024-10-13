using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine("video is playing...");
        }
        public void Stop() 
        {
            Console.WriteLine("video is stopped...");
        }

    }
}
