using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace sampleAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            AppCenter.Start("android={207fa13f-7e32-416d-ba75-b087bc7cf3e4};" +
                   "ios={83f0590b-0593-4dbf-9a7f-69b74de8c3bd};",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new ButtonPage();
        }
    }
}
