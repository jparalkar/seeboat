using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage.Table;

namespace DataUploader
{
    class EntryGenerator
    {
        public WaterData entryForTheCloud;
        //public List<WaterData> entriesForTheCloud = new List<WaterData>();
        public Hashtable dictionary = new Hashtable();
        private int NumberBoat = 1;
        public void GenerateCloudEntry(List<List<string>> data, int numberRound)
        {
            foreach (List<string> d in data)
            {

                if (!dictionary.ContainsKey(d[0]))
                {
                    dictionary[d[0]] = "Boat" + NumberBoat;
                    NumberBoat++;
                }
                WaterData entryForTheCloud = new WaterData(dictionary[d[0]].ToString(), numberRound + "")
                {
                    DeviceID = d[0],
                    GPSlat = d[1],
                    GPSlong = d[2],
                    GPShour = d[3],
                    GPSmin = d[4],
                    GPSsec = d[5],
                    GPSms = d[6],
                    TempVal = d[7],
                    CondVal = d[8],
                    PhVal = d[9],
                    MilliIrradiance = d[10]
                };
                // entriesForTheCloud.Add(entryForTheCloud);
                TableCloudStorage linktocloud = new TableCloudStorage(entryForTheCloud);
                linktocloud.PrepDataForCloud();
                linktocloud.SendDataToCloud();
                numberRound++;

            }

        }
    }
}


//This class will input a double[] and create an entry, then set to something on the outsider, that's also an entry (return an entry), The output will then go into the cloudstorage