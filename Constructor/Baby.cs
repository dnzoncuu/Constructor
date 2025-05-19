using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Baby
    {
        //Field
        private string _name;
        private string _lastName;
        private DateTime _birthDay;
        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }
        // Null constructor
        public Baby()
        {
            Console.WriteLine("Ingaaaaaaaaa");
            BirthDay = DateTime.Now;
        }
        //Constructor
        public Baby(string name , string lastname)
        {
            _name = name;
            _lastName = lastname;
            Console.WriteLine("Ingaaaaaaaaa");
            BirthDay = DateTime.Now;
        }
        

    }
}
