using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BundleAPI.Models
{
    public class Customer
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _registrationNumber;

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public int Age { get; set; }

        public decimal Income { get; set; }

        public bool IsStudent { get; set; }

    }
}