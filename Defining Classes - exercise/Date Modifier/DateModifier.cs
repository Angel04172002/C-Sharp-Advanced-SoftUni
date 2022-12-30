using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static int CalculateDifferenceBetweenDates(string firstDateAsString, string secondDateAsString)
        {
            DateTime firstDate = DateTime.Parse(firstDateAsString);
            DateTime secondDate = DateTime.Parse(secondDateAsString);

            TimeSpan difference = secondDate - firstDate;

            return Math.Abs(difference.Days);
        }
    }
}
