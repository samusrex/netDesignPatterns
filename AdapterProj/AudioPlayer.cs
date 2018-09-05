using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProj
{
    public class AudioPlayer : IMediaPlayer
    {

        MediaAdapter ma;

        public void Play(string audiotype, string filename)
        {
            if (audiotype.Equals("mp3"))
            {
                Console.WriteLine("playing mp3 file:{0}", filename);
            }
            else if (audiotype.Equals("mp4") || audiotype.Equals("vlc"))
            {

                ma = new MediaAdapter(audiotype);
                ma.Play(audiotype, filename);


            }
            else {

                Console.WriteLine("Invalid Media {0} , not suported",audiotype);
            }

        }
    }
}
