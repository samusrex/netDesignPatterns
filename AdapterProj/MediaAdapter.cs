using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProj
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advanced;

        public MediaAdapter(string audiotype)
        {
            if (audiotype.Equals("vlc"))
            {

               advanced = new VlcPlayer();

            }
            else if (audiotype.Equals("mp4"))
            {

               advanced = new MP4Player();
            }

        }

        public void Play(string audiotype, string filename)
        {
            if (audiotype.Equals("vlc"))
            {

                advanced.PlayVlc(filename);
            }
            else if (audiotype.Equals("mp4"))
            {
                advanced.PlayMP4(filename);
            }
        }
    }
}
