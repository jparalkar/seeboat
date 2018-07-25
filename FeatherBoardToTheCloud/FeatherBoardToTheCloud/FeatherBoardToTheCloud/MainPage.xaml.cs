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
            FileParser fileInterperter = new FileParser("recieverData.txt");
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
