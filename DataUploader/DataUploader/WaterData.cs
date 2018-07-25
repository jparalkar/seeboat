﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataUploader
{
    public class WaterData : TableEntity
    {

        public WaterData(string temppartitionkey, string temprowkey)

        {
            this.PartitionKey = temppartitionkey;
            this.RowKey = temprowkey;
        }


        public WaterData() { }

        public string DeviceID { get; set; }

        public string GPSlat { get; set; }
        public string GPSlong { get; set; }
        public string GPShour { get; set; }
        public string GPSmin { get; set; }
        public string GPSsec { get; set; }
        public string GPSms { get; set; }
        public string TempVal { get; set; }
        public string CondVal { get; set; }
        public string PhVal { get; set; }
        public string MilliIrradiance { get; set; }
    }

}


