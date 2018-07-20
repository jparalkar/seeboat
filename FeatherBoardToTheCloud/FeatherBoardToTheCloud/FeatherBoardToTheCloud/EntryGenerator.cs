using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage.Table;

namespace FeatherBoardToTheCloud
{
    class EntryGenerator
    {
        public BoatWaterData entryForTheCloud;
        private double[] dataInArrForm;
        private int roundNumber;
        public EntryGenerator(double[] doubleArray, int numberRound)
        {
            dataInArrForm = doubleArray;
            roundNumber = numberRound;
        } 
        public void GenerateEntry()
        {
            entryForTheCloud = new BoatWaterData(dataInArrForm[0] + "", roundNumber + "")
            {
                DeviceID = dataInArrForm[0],
                GPSlat = dataInArrForm[1],
                GPSlong =dataInArrForm[2],
                GPShour = dataInArrForm[3],
                GPSmin = dataInArrForm[4],
                GPSsec = dataInArrForm[5],
                GPSms = dataInArrForm[6],
                TempVal = dataInArrForm[7],
                CondVal =dataInArrForm[8],
                PhVal = dataInArrForm[9],
                MilliIrradiance = dataInArrForm[10]
            };

        }
    }
}


//This class will input a double[] and create an entry, then set to something on the outsider, that's also an entry (return an entry), The output will then go into the cloudstorage