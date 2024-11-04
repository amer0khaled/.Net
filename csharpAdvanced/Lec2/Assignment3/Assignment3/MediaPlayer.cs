using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class MediaPlayer : IMedia
    {
        public IMedia Media {  get; set; }
        public MediaPlayer() 
        {
        }
        public MediaPlayer(IMedia media)
        {
            this.Media = media;
        }

        public void Play()
        {
            Media.Play();
        }
        public void Stop()
        {
            Media.Stop();
        }
    }
}
