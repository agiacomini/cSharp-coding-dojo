using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeapYearService;

namespace CodingDojo
{
    public class LeapYearShould
    {
        LeapYear leapYear;
        public LeapYearShould()
        {
            leapYear = new LeapYear();
        }

        [Fact]
        public void Not_be_a_leap_year_if_not_divisible_by_4()
        {
            // When
            leapYear.SetYear(1997);
        
            // Then
            Assert.False(leapYear.isLeapYear(), "1997 is NOT a Leap Year");
        }

        [Fact]
        public void Is_leap_year_if_divisible_by_4()
        {
            // When
            leapYear.SetYear(1996);
        
            // Then
            Assert.True(leapYear.isLeapYear(), "1996 is a Leap Year");
        }

        [Fact]
        public void Is_leap_year_if_divisible_by_400()
        {
            // When
            leapYear.SetYear(1600);
            // Then
            Assert.True(leapYear.isLeapYear(), "1600 is a Leap Year");
        }

        [Fact]
        public void Not_be_a_leap_year_if_divisible_by_100_but_not_divisible_by_400()
        {
            // When
            leapYear.SetYear(1800);
        
            // Then
            Assert.False(leapYear.isLeapYear(), "1800 is NOT a Leap Year");
        }

        // [Fact]
        [Theory]
        [InlineData(2020)]
        [InlineData(2016)]
        [InlineData(2012)]
        [InlineData(2008)]
        [InlineData(1996)]
        [InlineData(1600)]
        public void years_should_be_leap_year(int year)
        {
            // When
            leapYear.SetYear(year);
        
            // Then
            Assert.True(leapYear.isLeapYear(), $"{year} should a leap year");
        }

        [Theory]
        [InlineData(1997)]
        [InlineData(1800)]
        public void years_should_be_NOT_leap_year(int year)
        {
            // When
            leapYear.SetYear(year);
        
            // Then
            Assert.False(leapYear.isLeapYear(), $"{year} should NOT a leap year");
        }
    }
}