using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Net;

[assembly:Xamarin.Forms.Dependency(typeof(HPlusSports.Droid.NetworkManager))]
namespace HPlusSports.Droid
{
    public class NetworkManager : INetworkManager
    {
        Context ctx = Android.App.Application.Context;

        [Obsolete]
        public bool IsNetworkConnected()
        {
            var cSvc = (ConnectivityManager)ctx.GetSystemService(Context.ConnectivityService);
            return cSvc.ActiveNetworkInfo != null && cSvc.ActiveNetworkInfo.IsConnected;
        }
    }
}