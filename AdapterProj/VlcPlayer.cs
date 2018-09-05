using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProj
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMP4(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("playing vlc file {0}", fileName);
        }
    }
}
