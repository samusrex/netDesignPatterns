using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterProj
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> res = new List<Person>();

            foreach (var item in persons) {

                if (item.GetGender().Equals("FEMALE")) {

                    res.Add(item);
                }
            }

            return res;
        }
    }
}
