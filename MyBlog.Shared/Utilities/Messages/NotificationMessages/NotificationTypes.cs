using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Shared.Utilities.Messages.NotificationMessages
{
    public enum NotificationTypes
    {
        DatabaseTracking = 0,
        Reminder = 1,
        BirthDayReminder = 2,
        MonthlyProductCareReminder = 3,
        ThreeMonthlyProductCareReminder = 4,
        SixMonthlyProductCareReminder = 5,
        YearlyProductCareReminder = 6,
    }
}
