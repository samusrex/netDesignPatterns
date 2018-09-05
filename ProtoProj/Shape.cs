using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoProj
{
    public abstract class Shape : ICloneable
    {
        private string Id;
        protected String type;

        public abstract void Draw();

        public String GetType()
        {
            return type;
        }
        public String GetId()
        {

            return this.Id;
        }

        public void SetId(String Id)
        {
            this.Id = Id;

        }




        public object Clone()
        {
            Object clone = null;
            try {
                //Create copy current object.
                clone = base.MemberwiseClone();

            } catch { }

            return clone;
        }
    }
}
