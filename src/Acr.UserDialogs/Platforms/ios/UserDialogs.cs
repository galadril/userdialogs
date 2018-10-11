using System;
using UIKit;


namespace Acr.UserDialogs
{
    public static partial class UserDialogs
    {
        static UserDialogs()
        {
            Instance = new UserDialogsImpl();
        }


        /// <summary>
        /// OPTIONAL: Initialize iOS user dialogs with your top viewcontroll function
        /// </summary>
        public static void Init(Func<UIViewController> viewControllerFunc)
        {
            Instance = new UserDialogsImpl(viewControllerFunc);
        }
    }
}
