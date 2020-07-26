using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;

namespace CommonLibraryMyApp.StorageAzure
{

    public interface IAzureStorageConfig
    {
        string ConnectionString => "DefaultEndpointsProtocol=https;AccountName=dasugollam;AccountKey=JIOyGwxCjj7Jrg53Fo5brZDsp9KoO1QRzzUFlvBO+TkmOWCCcir+otlq7Nq637lsDfNcAkFtvESNBtJtlR5DQg==;EndpointSuffix=core.windows.net";

        string ImagesContainerName => "";

    }
}
