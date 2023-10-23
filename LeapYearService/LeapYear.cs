using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeapYearService
{
    public class LeapYear
    {
        private int year;
    
        public LeapYear(){}

        public LeapYear(int year)
        {
            this.year = year;
        }
        public int GetYear(){ return this.year; }
        public void SetYear(int year){ this.year = year; }
        public bool isLeapYear()
        {   
            return isDivisibleBy(4) && 
                   !(isDivisibleBy(100) && isNotDivisibleBy(400));   
        }
        private bool isDivisibleBy(int number)
        {
            return year % number == 0;
        }
        private bool isNotDivisibleBy(int number)
        {
            return year % number != 0;
        }
    }
}