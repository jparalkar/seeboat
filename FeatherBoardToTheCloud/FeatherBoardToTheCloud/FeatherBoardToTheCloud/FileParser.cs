using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

/*This class can take in a string of 11 data points and then return an array of doubles with each point being a single item.
 * There was functionality for reading a file but that has been commented out because I couldn't get the program to find the file.
 */

namespace FeatherBoardToTheCloud
{
    public class FileParser
    {
        private string[] dataPacketStandIn;
        private string nameOfFile;
        private double[] DataInArrForm = new double[11];
        public FileParser(string filename)
        {
            nameOfFile = filename;
           
        }
        public double[] FileToArray()
        {
            dataPacketStandIn = File.ReadAllLines("C:\\repos\\seeboat\\recieverData.txt");

            string[] temporaryStringDatum;


            foreach (string dataPacket in dataPacketStandIn)
            {
                for (int i = 0; i < dataPacket.Length - 1; i++)
                {
                    System.Diagnostics.Debug.WriteLine("************************************/n****************************/n***********************/n");
                    System.Diagnostics.Debug.WriteLine(dataPacket);

                    temporaryStringDatum = dataPacket.Split(", ".ToCharArray());
                    System.Diagnostics.Debug.WriteLine(temporaryStringDatum);
                    System.Diagnostics.Debug.WriteLine("************************************/n****************************/n***********************/n");

                }
            }





            //string temporaryStringDatum;
            //double temporaryDoubleDatum;
            //for (int i = 0; i < DataInArrForm.Length-1; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine("************************************/n****************************/n***********************/n");
            //    System.Diagnostics.Debug.WriteLine(dataPacketStandIn.IndexOf(','));
            //    System.Diagnostics.Debug.WriteLine("************************************/n****************************/n***********************/n");
            //    temporaryStringDatum = dataPacketStandIn.Substring(0, dataPacketStandIn.IndexOf(','));               
            //    temporaryDoubleDatum = convertStrToDouble(temporaryStringDatum);
            //    DataInArrForm[i] = temporaryDoubleDatum;
            //    dataPacketStandIn = dataPacketStandIn.Substring(dataPacketStandIn.IndexOf(',') + 1);

            //}

            //temporaryStringDatum = dataPacketStandIn.Substring(0);
            //temporaryDoubleDatum = convertStrToDouble(temporaryStringDatum);
            //DataInArrForm[10] = temporaryDoubleDatum;
            //dataPacketStandIn = dataPacketStandIn.Substring(dataPacketStandIn.IndexOf(',') + 1);
            //var content = String.Empty;
            //using (var streamReader = File.OpenText(nameOfFile))
            //{
            //content = streamReader.ReadToEnd();
            //}
            //string stringFormOfData = File.ReadAllText(@"C:\" + nameOfFile);
            return DataInArrForm;
        }
        private double convertStrToDouble(string convertee)
        {
            return Double.Parse(convertee);
        }

    }
}




