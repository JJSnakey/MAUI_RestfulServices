using Assignment4Part3.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Assignment4Part3.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}