using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_C_Sharp
{
    internal class Magazine 
    {
        private string _title;
        private string _year;
        private string _description;
        private string _phone;
        private string _email;
        public int Employees { get; set; }
        public Magazine(int employees)
        {
            Employees = employees;
        }
        public static Magazine operator +(Magazine m1, Magazine m2)
        {
            return new Magazine(m1.Employees + m2.Employees);
        }
        public static Magazine operator +(Magazine m1, int value)
        {
            return new Magazine(m1.Employees + value);
        }
        public static Magazine operator -(Magazine m1, Magazine m2)
        {
            return new Magazine(m1.Employees - m2.Employees);
        }
        public static Magazine operator -(Magazine m1, int value)
        {
            return new Magazine(m1.Employees - value);
        }
        public static bool operator ==(Magazine m1, Magazine m2)
        {
            return m1.Employees == m2.Employees;
        }
        public static bool operator !=(Magazine m1, Magazine m2)
        {
            return m1.Employees != m2.Employees;
        }
        public static bool operator <(Magazine m1, Magazine m2)
        {
            return m1.Employees < m2.Employees;
        }
        public static bool operator >(Magazine m1, Magazine m2)
        {
            return m1.Employees > m2.Employees;
        }
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Variable can't be empty");
                }
                _title = value;
            }
        }
        public string Year
        {
            get => _year;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Variable can't be empty");
                }
                _year = value;
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Variable can't be empty");
                }
                _description = value;
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Variable can't be empty");
                }
                _phone = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Variable can't be empty");
                }
                _email = value;
            }
        }
        public override string ToString()
        {
            var input = new StringBuilder();

            input.AppendLine($"Numer of Employees: {Employees}");

            return input.ToString();
        }
    }
}
