using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsApp.ViewModels;

namespace XamarinFormsApp.Views
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