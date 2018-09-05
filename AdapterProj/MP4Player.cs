using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProj
{
    class MP4Player : IAdvancedMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
            Console.WriteLine("playing mp4 file:{0}", fileName);
        }

        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
