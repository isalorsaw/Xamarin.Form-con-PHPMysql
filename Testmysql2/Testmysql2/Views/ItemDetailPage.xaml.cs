using System.ComponentModel;
using Testmysql2.ViewModels;
using Xamarin.Forms;

namespace Testmysql2.Views
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