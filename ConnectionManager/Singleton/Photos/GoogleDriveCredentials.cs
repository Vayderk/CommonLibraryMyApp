using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace MyApp.ConnectionManager.Singleton.Photos
{
    public class GoogleDriveCredentials
    {
        private GoogleDriveCredentials() { }

        private static UserCredential _instance;

        static string[] Scopes = { DriveService.Scope.DriveReadonly };

        public static UserCredential GetInstance()
        {
            if (_instance == null)
            {
                _instance = GetCredentialsFromGoogleDrive();
            }
            return _instance;
        }

        public static UserCredential GetCredentialsFromGoogleDrive()
        {
            UserCredential credential;
            using (var stream =
                new FileStream(@"C:\Users\vayde\Desktop\MyProject\MyApp\MyApp\Forms\Gallery\credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            return credential;
        }

    }
}
