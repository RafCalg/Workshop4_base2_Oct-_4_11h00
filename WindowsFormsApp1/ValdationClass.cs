using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ValdationClass
    {
        // check package name which could not be null
        public static bool isValidPackageName(string str)
        {
            return (string.IsNullOrEmpty(str)) ? false: true;
        }

        // check start date which should be equal or greater than current date 
        public bool isValidStartDate(DateTime date)
        {
            return (date >= DateTime.Now) ? true : false;
        }

        // check end date which should be greater than start date
        public bool isValidEndDate(DateTime startDate, DateTime endDate)
        {
            return (endDate > startDate) ? true : false;
        }

        // check description name which could not be null
        public bool isValidDescription(string str)
        {
            return (string.IsNullOrEmpty(str)) ? false : true;
        }

        // check base price which should be greater than 0
        public bool isValidBasePrice(decimal num)
        {
            return (num >= 0) ? true : false;
        }

        // check commission which should be greater than 0 and no more than base price
        public bool isValidAgencyCommission(decimal basePrice, decimal commission)
        {
            return (commission < basePrice && commission > 0) ? true : false;
        }

        // check product name which could not be null
        public bool isValidProductName(string str)
        {
            return (string.IsNullOrEmpty(str)) ? false : true;
        }

        // check supplier name which could not be null
        public bool isValidSupplier(string str)
        {
            return (string.IsNullOrEmpty(str)) ? false : true;
        }


    }
}
