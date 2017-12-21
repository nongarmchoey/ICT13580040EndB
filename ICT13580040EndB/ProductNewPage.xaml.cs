using System;
using System.Collections.Generic;
using ICT13580040EndB.Models;
using Xamarin.Forms;

namespace ICT13580040EndB
{
    public partial class ProductNewPage : ContentPage
    {
        public ProductNewPage()
        {
            InitializeComponent();
          

            typePicker.Items.Add("รถยนต์มือหนึ่ง");
            typePicker.Items.Add("รถยนต์มือสอง");

            brandPicker.Items.Add("Honda");
            brandPicker.Items.Add("Toyota");
            brandPicker.Items.Add("Nissan");
            brandPicker.Items.Add("Hyndai");
            brandPicker.Items.Add("Isuzu");

            colorPicker.Items.Add("ดำ");
            colorPicker.Items.Add("ขาว");
            colorPicker.Items.Add("เทา");
            colorPicker.Items.Add("ทอง");
            colorPicker.Items.Add("บรอนซ์");

            countryPicker.Items.Add("กรุงเทพ");
            countryPicker.Items.Add("นครปฐม");
            countryPicker.Items.Add("นนทบุรี");
            countryPicker.Items.Add("ปทุมธานี");
            countryPicker.Items.Add("สมุทรปราการ");
            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;


        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");
            if (isOk)
            {
                var product = new Product();
                product.Type = typePicker.SelectedItem.ToString();
                product.Brand = brandPicker.SelectedItem.ToString();
                product.Generation = generatoinEntry.Text;
                product.Date = dateEntry.Text;

                product.Color = colorPicker.SelectedItem.ToString();
                product.Deler = delerSwitch.IsToggled;
                product.Detail = detailEditor.Text;
                product.Price = priceEntry.Text;
                product.Country = countryPicker.SelectedItem.ToString();
                product.Phone = phoneEntry.Text;

            }
        }

       

        void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
