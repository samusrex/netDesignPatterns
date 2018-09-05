using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProj
{
    public interface IMediaPlayer
    {
        void Play(string audiotype,string filename);
    }
}
