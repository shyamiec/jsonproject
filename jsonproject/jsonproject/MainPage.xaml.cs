using jsonproject.model;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jsonproject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private string url2 = "https://api.myjson.com/bins/cxif6";
        private HttpClient client = new HttpClient();
        
        ObservableCollection<Person_Detail> list1;
        public MainPage()
        {
            
            InitializeComponent();
            GetList();
        }
        
        public async void GetList()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                try
                {

                    var detail = await client.GetStringAsync(url2);
                    var tr = JsonConvert.DeserializeObject<List<Person_Detail>>(detail);
                    list1 = new ObservableCollection<Person_Detail>(tr);
                    myList.ItemsSource = list1;

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }

        private void myList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var demo =(Person_Detail) e.SelectedItem;
            
            name.Text = demo.Name;
            sdetail.Text = demo.Sdetail;
            ldetail.Text = demo.Ldetail;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new EntryPage()));
        }
    }
}
