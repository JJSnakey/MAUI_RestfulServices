using Assignment4_3.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Assignment4_3.Views
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