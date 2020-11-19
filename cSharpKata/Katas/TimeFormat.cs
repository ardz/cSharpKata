using System;

namespace cSharpKata.Katas
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds >= 359999)
            {
                return "99:59:59";
            }

            var timespan = TimeSpan.FromSeconds(seconds);

            return timespan.ToString(@"hh\:mm\:ss");
        }
    }
}
