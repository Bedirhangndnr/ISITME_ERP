using MyBlog.Shared.Utilities.Messages.NotificationMessages;

public class NotificationMessageService
{
    public static string GetMessage(NotificationMessageTypes notificationMessageTypes, string tableName, string modifiedByName)
    {
        switch (notificationMessageTypes)
        {
            case NotificationMessageTypes.Added:
                return $"{tableName} Adlı Tabloya {modifiedByName} Adlı Kullanıcı Tarafından Veri Eklendi.";
            case NotificationMessageTypes.Updated:
                return $"{tableName} Adlı Tablo {modifiedByName} Adlı Kullanıcı Tarafından Güncellendi.";
            case NotificationMessageTypes.Deleted:
                return $"{tableName} Adlı Tablo {modifiedByName} Adlı Kullanıcı Tarafından Silindi.";
            case NotificationMessageTypes.Activated:
                return $"{tableName} Adlı Tablo {modifiedByName} Adlı Kullanıcı Tarafından Aktive Edildi.";
            case NotificationMessageTypes.DeActivated:
                return $"{tableName} Adlı Tabloya {modifiedByName} Adlı Kullanıcı Tarafından Tekrar Aktif Edildi.";
            case NotificationMessageTypes.UndoDeleted:
                return $"{tableName} Adlı Tabloya {modifiedByName} Adlı Kullanıcı Tarafından Kalıcı Olarak Silindi!.";
            case NotificationMessageTypes.HardDeleted:
                return $"{tableName} Adlı Tabloya {modifiedByName} Adlı Kullanıcı Tarafından Veri Eklendi.";
            default:
                return "";
        }
    }
    public static string GetTitle(NotificationMessageTypes notificationMessageTypes)
    {
        switch (notificationMessageTypes)
        {
            case NotificationMessageTypes.Added:
                return "Ekleme";
            case NotificationMessageTypes.Updated:
                return "Güncelleme";
            case NotificationMessageTypes.Deleted:
                return "Silme";
            case NotificationMessageTypes.Activated:
                return "Aktive Etme";
            case NotificationMessageTypes.DeActivated:
                return "Pasifize Etme";
            case NotificationMessageTypes.UndoDeleted:
                return "Silme İşlemini Geri Alma";
            case NotificationMessageTypes.HardDeleted:
                return "Kalıcı Silme";
            default:
                return "";
        }
    }
    public static string GetType(NotificationTypes notificationTypes)
    {
        switch (notificationTypes)
        {
            case NotificationTypes.DatabaseTracking:
                return "DatabaseTracking";
            case NotificationTypes.Reminder:
                return "Reminder";
            default:
                return "";
        }
    }
}