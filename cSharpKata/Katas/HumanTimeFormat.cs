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

            var duration = TimeSpan.FromSeconds(inputSeconds);
            var allTimeDurations = new Dictionary<string, int>();

            // work out how many whole years from seconds we're dealing with
            var years = duration.Days / 365;
            var yearsLabel = years > 1 ? "years" : "year";
            allTimeDurations.Add(yearsLabel, years);

            // work out what the days remaining are
            var wholeYearsInDays = years * 365;
            var days = duration.Days - wholeYearsInDays;
            var daysLabel = days > 1 ? "days" : "day";
            allTimeDurations.Add(daysLabel, days);

            // add the rest
            var hours = duration.Hours;
            var hoursLabel = duration.Hours > 1 ? "hours" : "hour";
            allTimeDurations.Add(hoursLabel, hours);

            var minutes = duration.Minutes;
            var minutesLabel = duration.Minutes > 1 ? "minutes" : "minute";
            allTimeDurations.Add(minutesLabel, minutes);

            var seconds = duration.Seconds;
            var secondsLabel = duration.Seconds > 1 ? "seconds" : "second";
            var readableSeconds = seconds + secondsLabel;
            allTimeDurations.Add(secondsLabel, seconds);

            // only get the time values where value isn't 0
            var nonZeroValues = allTimeDurations.Where(x => x.Value > 0).Select(x => x.Value + " " + x.Key);

            // edge case, if there's only one in the list, don't output the "and" just output the time value
            if (nonZeroValues.Count() == 1)
            {
                return nonZeroValues.First();
            }

            // else just return the string joined up with commas and "and"
            return string.Join(", ", nonZeroValues.Take(nonZeroValues.Count() - 1)) + " and " + nonZeroValues.Last();
        }
    }
}
