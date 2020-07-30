using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Domain.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime GetBrazilianDateTime()
        {
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
        }
    }
}
