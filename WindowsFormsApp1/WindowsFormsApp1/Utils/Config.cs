using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Config
{
    class Config
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ODk7Qlr8hR80rttKSI41lfaYR7ywCvCBo9XEUfIH",
            BasePath = "https://foodappdesktop-default-rtdb.firebaseio.com/",
        };

        public static IFirebaseClient client;
        public static FirebaseResponse response;

    }
}
