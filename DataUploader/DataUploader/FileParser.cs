using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

/*This class can take in a string of 11 data points and then return an array of doubles with each point being a single item.
 * There was functionality for reading a file but that has been commented out because I couldn't get the program to find the file.
 */

namespace DataUploader
{
    public class FileParser
    {
        private static string[] dataPacketStandIn;
        private string nameOfFile;
        private double[] DataInArrForm = new double[11];
        public FileParser(string filename)
        {
            nameOfFile = filename;

        }
        public static List<List<string>> FileToArray()
        {
            dataPacketStandIn = File.ReadAllLines("C:\\repos\\seeboat\\recieverData.txt");

            List<List<string>> boatData = new List<List<string>>();

            string[] tempBoatDataRow;

            for (int i = 0; i < dataPacketStandIn.Length - 1; i += 2)
            {
                tempBoatDataRow = dataPacketStandIn[i].Split(", ".ToCharArray());
                List<string> tempBoatData = new List<string>();

                for (int g = 1; g < tempBoatDataRow.Length; g += 2)
                {
                    tempBoatData.Add(tempBoatDataRow[g].Split("=".ToCharArray())[1]);
                }
                boatData.Add(tempBoatData);
            }
            return boatData;
        }

        static void Main()
        {
            List<List<string>> data = FileToArray();

            EntryGenerator entryCreator = new EntryGenerator();
            entryCreator.GenerateCloudEntry(data, 1);

      
        }
    }
}