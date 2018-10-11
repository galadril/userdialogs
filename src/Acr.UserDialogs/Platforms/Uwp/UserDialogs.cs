using System;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.ApplicationModel.Core;


namespace Acr.UserDialogs
{
    public static partial class UserDialogs
    {
        static UserDialogs()
        {
            Instance = new UserDialogsImpl();
        }


        /// <summary>
        /// Initialize UWP user dialogs
        /// </summary>
        public static void Init(Func<Action, Task> customDispatcher = null)
        {
            Instance = new UserDialogsImpl(customDispatcher);
        }
    }
}
