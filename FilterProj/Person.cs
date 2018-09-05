using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterProj
{
    public class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;


        public Person(string Name, string gender, string ms)
        {
            this.name = Name;
            this.gender = gender;
            this.maritalStatus = ms;
        }


        public string GetName() {

            return this.name;
        }
        public string GetGender() {

            return this.gender;
        }

        public string GetMaritalStatus() {

            return this.maritalStatus;
        }
        
    }
}
