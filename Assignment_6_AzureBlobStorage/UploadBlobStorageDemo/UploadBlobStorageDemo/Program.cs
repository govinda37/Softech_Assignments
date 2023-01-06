using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UploadBlobStorageDemo
{
    internal class Program
    {
        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=govinda1;AccountKey=fMyGioukTPpinmju2Zr/y1BczCcN+f0r0o+5KIbQeM64Zo7DlvcMhHo/XxNi13BPMom2XviqdbYX+AStOrf2+A==;EndpointSuffix=core.windows.net";
        static string containerName = "newdemocontainer";
        static  void Main(string[] args)
        {
            
            
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient containerClient = blobServiceClient.CreateBlobContainer(containerName);
             var files = Directory.GetFiles(@"C:\Users\Govinda.kolhi\Pictures\Screenshots");
           // var files = Directory.GetFiles(@"C:\Users\Govinda.kolhi\Videos\");
            foreach (var file in files)
            {
               using(MemoryStream stream= new MemoryStream(File.ReadAllBytes(file)))
                {
                    containerClient.UploadBlob(Path.GetFileName(file), stream);
                }
                Console.WriteLine(file + "Uploaded!");
            }
            Console.Read();

        }
    }
}
