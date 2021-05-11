using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatabaseSaveFile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var tabledis = await App.Sqldb.DisplayItem();
            if (tabledis != null)
            {
                Tabledisplay.ItemsSource = tabledis;
            }
        }

        public async void BtnAdd_Clicked (object sender, EventArgs e)
        {
         if (!string.IsNullOrEmpty(price.Text) || !string.IsNullOrEmpty(quantity.Text) || !string.IsNullOrEmpty(description.Text))
            { 
            Rhysindb rhysindb = new Rhysindb()
            {
                //ItemNum = int.Parse(itemnum.Text),
                Desc = description.Text,
                Price = double.Parse(price.Text),
                Quantity=int.Parse(quantity.Text),
                Subtotal= (double.Parse(quantity.Text) * double.Parse(price.Text))
            };

            await App.Sqldb.SaveItem(rhysindb);
            string display = "Item Number: " +rhysindb.ItemNum + 
                "\nDescription: "+rhysindb.Desc+ 
                "\nPrice: "+rhysindb.Price+
                "\nQuantity: "+rhysindb.Quantity+
                "\nSubtutal: "+rhysindb.Subtotal
                ;
            await DisplayAlert("Success", ""+display, "OK");

            var tabledis = await App.Sqldb.DisplayItem();
            if (tabledis !=null)
            {
                Tabledisplay.ItemsSource = tabledis;
            }
            }
            else
            {
                await DisplayAlert("Error", "Input Data", "OK");
            }
        }




    }
}
