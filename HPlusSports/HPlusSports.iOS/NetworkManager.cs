using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using System.Net;
using SystemConfiguration;

[assembly:Xamarin.Forms.Dependency(typeof(HPlusSports.iOS.NetworkManager))]
namespace HPlusSports.iOS
{
    class NetworkManager : INetworkManager
    {
        public bool IsNetworkConnected()
        {
            NetworkReachabilityFlags flags;
            var address = new IPAddress(0);
            var reachability = new NetworkReachability(address);

            if(reachability.TryGetFlags(out flags))
            {
                return (flags & NetworkReachabilityFlags.Reachable) != 0;
            }
            else
            {
                return false;
            }
        }
    }
}