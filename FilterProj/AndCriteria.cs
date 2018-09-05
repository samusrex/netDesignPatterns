using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterProj
{
    public class AndCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public AndCriteria(ICriteria c1, ICriteria c2)
        {
            this.criteria = c1;
            this.otherCriteria = c2;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> res = criteria.MeetCriteria(persons);
            return otherCriteria.MeetCriteria(res);
        }
    }
}
