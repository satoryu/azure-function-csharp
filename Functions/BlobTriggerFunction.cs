using System;
using System.IO;
using Microsoft.WindowsAzure.Storage;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Function
{
    public class BlobTriggerFunction
    {
        [StorageAccount("MyBlobStorage")]
        [FunctionName("BlobTriggerFunction")]
        public static void Run([BlobTrigger("uploaded/{name}")] Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"BlobTrigger function processed: {name} ({myBlob.Length}");
        }
    }
}
