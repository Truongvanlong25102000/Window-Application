using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View.Screen;

namespace WindowsFormsApp1.Config
{
    class Config
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ODk7Qlr8hR80rttKSI41lfaYR7ywCvCBo9XEUfIH",
            BasePath = "https://foodappdesktop-default-rtdb.firebaseio.com/",
        };

        public static IFirebaseClient client = new FireSharp.FirebaseClient(config);
        public static FirebaseResponse response;
        public static string userName="";
        public static User user;

    }
}
