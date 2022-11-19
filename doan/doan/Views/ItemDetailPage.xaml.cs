using doan.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace doan.Views
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