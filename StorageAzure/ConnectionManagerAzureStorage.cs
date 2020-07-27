using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace CommonLibraryMyApp.StorageAzure
{
    public class ConnectionManagerAzureStorage
    {


        private static volatile ConnectionManagerAzureStorage instance;
        private static object syncRoot = new Object();
        private string ConnectionString => "DefaultEndpointsProtocol=https;AccountName=dasugollam;AccountKey=***********==;EndpointSuffix=core.windows.net";
        private string ImagesContainerName => @"fotos-dani-1985-2003";


        public CloudStorageAccount StorageAccount { get; private set; }
        public CloudBlobClient BlobClient { get; private set; }
        public CloudBlobContainer Container { get; set; }

        private ConnectionManagerAzureStorage()
        {
            StorageAccount = CloudStorageAccount.Parse(ConnectionString);

            //instantiate the client
            BlobClient = StorageAccount.CreateCloudBlobClient();

        }

        public static ConnectionManagerAzureStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ConnectionManagerAzureStorage();
                    }
                }

                return instance;
            }
        }

    }


}
