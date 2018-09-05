using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProj
{
    public interface IAdvancedMediaPlayer
    {
        void PlayMP4(string fileName);
        void PlayVlc(string fileName);
    }
}
