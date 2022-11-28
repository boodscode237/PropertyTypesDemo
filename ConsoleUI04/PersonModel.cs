using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI04
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        private string _password;

        public string Password
        {
            set { _password = value; }
        }

        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // public int Age { get; set; }
        private int _age;

        public int Age
        {
            get 
            { 
                return _age; 
            }
            set 
            {
                if (value >= 0 && value < 146)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be in the range 0 to 145");
                }
            }
        }

        private string _bankCard;

        public string BankCard
        {
            get 
            {
                string output = "****-****-****-" + _bankCard.Substring(_bankCard.Length - 4);
                return output; 
            }
            set { _bankCard = value; }
        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
        public PersonModel()
        {

        }
    }
}
