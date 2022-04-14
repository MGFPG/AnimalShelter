using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = DateTime.Now.Year - birthday.Year >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set    
            { 
                _Birthday = value; 
                _IsQualified = DateTime.Now.Year - value.Year >= 18;
            }
        }

        public int Age  // 속성
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        public bool GetIsQiaulified()
        {
            return _IsQualified;
        }

        public bool IsQualified  // 속성
        { 
            get { return _IsQualified; } // 읽기 전용
        }

        public string FullName  // 속성
        {
            get {   return FirstName + " " + LastName; }   // 읽기 전용
        }
    }
}
