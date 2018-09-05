using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterProj
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> res = new List<Person>();

            foreach (var person in persons)
            {

                if (person.GetGender().Equals("SINGLE"))
                {
                    res.Add(person);
                }

            }

            return res;
        }
    }
}
