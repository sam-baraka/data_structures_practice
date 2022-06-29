using MObile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MObile.Views
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