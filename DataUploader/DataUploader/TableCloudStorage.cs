using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataUploader
{
    public class TableCloudStorage
    {
        // private string KeyToStorageAccount;
        //private string NameOfDataTable;

        public static CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tealseeboateeststorage;AccountKey=3idKl/IEYFSMKmMfgvKUy+TSq4V1Q4fPf9HCCsdtrE1sluVuCe47vUjjRZevvvYPHB3C4DP+4wkei+kvGoQvJg==;EndpointSuffix=core.windows.net");
        public static CloudTableClient tableClient = cloudStorageAccount.CreateCloudTableClient();

        public CloudTable CloudDataTable = tableClient.GetTableReference("TestSeeboatData");
        // public List<WaterData> entriesForTheCloud;
        public WaterData entryForTheCloud;
        private TableBatchOperation batchOperator = new TableBatchOperation();

        public TableCloudStorage(WaterData newEntry)
        {
            entryForTheCloud = newEntry;

        }
        //public bool DoesTableExists()
        // {
        //   return CloudDataTable.ExistsAsync().Result;
        //}


        public void PrepDataForCloud()
        {
           // entriesForTheCloud.ForEach(delegate (WaterData entry)
           // {
               batchOperator.Add(TableOperation.InsertOrMerge(entryForTheCloud));
           // });
            
           

        }
        public void SendDataToCloud()
        {
            CloudDataTable.ExecuteBatch(batchOperator);
        }
    }

}
