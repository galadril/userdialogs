using System;


namespace Acr.UserDialogs
{
    public static partial class UserDialogs
    {
        static UserDialogs()
        {
            Instance = new UserDialogsImpl();
        }
    }
}
