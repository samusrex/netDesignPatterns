using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterProj
{
    public class OrCriteria : ICriteria
    {

        private ICriteria criteria;
        private ICriteria otherCriteria;


        public OrCriteria(ICriteria c1, ICriteria c2)
        {
            this.criteria = c1;
            this.otherCriteria = c2;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firtsCriteriaItems = criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = otherCriteria.MeetCriteria(persons);

            foreach (var person in otherCriteriaItems) {

                if (!firtsCriteriaItems.Contains(person)) {

                    firtsCriteriaItems.Add(person);

                }

            }
            return firtsCriteriaItems;

        }
    }
}
