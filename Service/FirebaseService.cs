using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Builder.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FirebaseService
    {
        private static bool _isFirebaseAppCreated = false;

        public static void InitializeFirebase()
        {
            if (!_isFirebaseAppCreated)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile("arms-acdfc-firebase-adminsdk-k69jb-12c5c29272.json")
                });
                _isFirebaseAppCreated = true;
            }
        }
    }
}
