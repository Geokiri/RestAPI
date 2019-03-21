using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bundles.Models;

namespace Bundles.Code
{
    public class BussinesRules
    {
        private Bundle _bundle = new Bundle();

        public string GetBundle(int age, bool isStudent, int income)
        {
            if(age < 18)
            {
                _bundle.Bundles = "Junior Saver";
            }
            else if (isStudent && age > 17)
            {
                _bundle.Bundles = "Student";
            }
            else if (income < 12000 && income > 0 && age > 17)
            {
                _bundle.Bundles = "Classic";
            }
            else if (income < 40000 && income > 12000 && age > 17)
            {
                _bundle.Bundles = "Classic Plus";
            }
            else if (income > 40000 && age > 17)
            {
                _bundle.Bundles = "Gold";
            }

            return _bundle.Bundles;
        }
    }
}