public class NotificationService()
{
    public void Get(string type, Action<string> sendNotification)
    {
        //if (type == "Email")
        //    return new ...();
        //else if (type == "SMS")
        //    return new ...();
        ////else if (type == "Push")
        ////	return new ...();

        //else
        //    throw new ArgumentException("Invalid notification type.");
        sendNotification(type);
    }
}

public delegate bool Func(string type);