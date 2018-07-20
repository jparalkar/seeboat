using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FeatherBoardToTheCloud
{
  public class TableCloudStorage
    {
       // private string KeyToStorageAccount;
        //private string NameOfDataTable;

        public static CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tealseeboateeststorage;AccountKey=F5GnHieen8Az50v0oR9cIkf7AywiF1O9vQI53TyNy4GqnpbFmzOrM1ztQ+NWf8ph/GfnQyrXe9usjY/tJBHIRA==;EndpointSuffix=core.windows.net");
        public static CloudTableClient tableClient = cloudStorageAccount.CreateCloudTableClient();

        public CloudTable CloudDataTable = tableClient.GetTableReference("TestSeeboatData");
        BoatWaterData entryForTheCloud;
        private TableBatchOperation batchOperator = new TableBatchOperation();

        public TableCloudStorage(BoatWaterData newEntry)
         {
            entryForTheCloud = newEntry;
        
         }
        //public bool DoesTableExists()
        // {
        //   return CloudDataTable.ExistsAsync().Result;
        //}

        
        public void PrepDataForCloud () 
        {
            batchOperator.Add(TableOperation.InsertOrMerge(entryForTheCloud));

        }
        public void SendDataToCloud()
        {
            CloudDataTable.ExecuteBatchAsync(batchOperator);
        }
    }

}
