using System;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*
Joshua Greer 1218576515
Assignment 4 Part 3
Main page of APP for 2 restful services
1) Encryption and Decryption
2) Get random string

both can be found at https://venus.sod.asu.edu/WSRepository/Services/
 */

namespace Assignment4Part3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //SERVICE 1: Encryption Decryption RESTful-----------------------------------------------------------
        private async void EncryptButton_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string result;
            try
            {
                var response = await client.GetAsync("https://venus.sod.asu.edu/WSRepository/Services/EncryptionRest/Service.svc/Encrypt?text=" + EncryptEntry.Text);
                response.EnsureSuccessStatusCode();
                result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");
            }
            catch (HttpRequestException ex)
            {
                result = ex.ToString();
            }
            EncryptLabel.Text = result;
            DecryptEntry.Text = result; // Auto fill the text for decryption
        }

        private async void DecryptButton_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string result;
            try
            {
                var response = await client.GetAsync(
                "https://venus.sod.asu.edu/WSRepository/Services/EncryptionRest/Service.svc/Decrypt?text=" + DecryptEntry.Text);
                response.EnsureSuccessStatusCode();
                result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");
            }
            catch (HttpRequestException ex)
            {
                result = ex.ToString();
            }
            DecryptLabel.Text = result;
        }
        //--------------------------------------------------------------------------------

        //SERVICE 2: Get random string RESTful service-----------------------------------

        private async void RandomButton_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string result;
            try
            {
                var response = await client.GetAsync("https://venus.sod.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/8");
                response.EnsureSuccessStatusCode();
                result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");
                result = result.Substring(68, 8);
            }
            catch (HttpRequestException ex)
            {
                result = ex.ToString();
            }
            GetRandomLabel.Text = result;
        }
    }

}
