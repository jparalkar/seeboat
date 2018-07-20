using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.WindowsAzure.Storage;
    

namespace FeatherBoardToTheCloud
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            FileParser fileInterperter = new FileParser("20.9, 10.4, 90.0, 33.3, 44.4, 55.5, 66.6, 77.7, 88.8, 99.9, 11.1");
            EntryGenerator EntryCreator = new EntryGenerator(fileInterperter.FileToArray(), 1);
            EntryCreator.GenerateEntry();
            TableCloudStorage linktocloud = new TableCloudStorage(EntryCreator.entryForTheCloud);
            linktocloud.PrepDataForCloud();
            //bool tableExisting = linktocloud.DoesTableExists();
          //  System.Diagnostics.Debug.WriteLine("************************************/n****************************/n***********************/n");
           // System.Diagnostics.Debug.WriteLine("" + linktocloud.doesTableExists().ToString());
           // System.Diagnostics.Debug.WriteLine("************************************/n****************************/n***********************/n");
            linktocloud.SendDataToCloud();

        }
    }
}
