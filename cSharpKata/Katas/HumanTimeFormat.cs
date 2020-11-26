using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharpKata.Katas
{
    public static class HumanTimeFormat
    {
        public static string Duration(int inputSeconds)
        {
            if (inputSeconds == 0)
            {
                return "now";
            }

            var foo = new Dictionary<string, int>();

            var duration = TimeSpan.FromSeconds(inputSeconds);

            // work out how many whole years from seconds we're dealing with
            var years = duration.Days / 365;
            var yearsLabel = years > 1 ? "years" : "year";
            foo.Add(yearsLabel, years);

            // work out what the days remaining are
            var wholeYearsInDays = years * 365;
            var days = duration.Days - wholeYearsInDays;
            var daysLabel = days > 1 ? "days" : "day";
            foo.Add(daysLabel, days);

            var hours = duration.Hours;
            var hoursLabel = duration.Hours > 1 ? "hours" : "hour";
            foo.Add(hoursLabel, hours);

            var minutes = duration.Minutes;
            var minutesLabel = duration.Minutes > 1 ? "minutes" : "minute";
            foo.Add(minutesLabel, minutes);

            var seconds = duration.Seconds;
            var secondsLabel = duration.Seconds > 1 ? "seconds" : "second";
            var readableSeconds = seconds + secondsLabel;
            foo.Add(secondsLabel, seconds);

            var nonZeroValues = foo.Where(x => x.Value > 0).Select(x => x.Value + " " + x.Key);

            if (nonZeroValues.Count() == 1)
            {
                return nonZeroValues.First();
            }

            return string.Join(", ", nonZeroValues.Take(nonZeroValues.Count() - 1)) + " and " + nonZeroValues.Last();
        }
    }
}
