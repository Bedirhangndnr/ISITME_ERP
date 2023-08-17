using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Shared.Utilities.Messages.NotificationMessages
{
    public enum NotificationMessageTypes
    {
        Added = 0,
        Updated = 1,
        Deleted = 2,
        Activated = 3,
        DeActivated = 4,
        UndoDeleted = 5,
        HardDeleted = 6,
    }
    static public class DeleteTypesConstants
    {
        public const string Reminder = "Reminder";
        public const string DatabaseTracking = "DatabaseTracking";
    }
}
