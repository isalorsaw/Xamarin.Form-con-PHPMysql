using System;
using System.Collections.Generic;
using System.ComponentModel;
using Testmysql2.Models;
using Testmysql2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testmysql2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}