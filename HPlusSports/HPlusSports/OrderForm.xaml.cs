using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    [Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Skip)]
    public partial class OrderForm : TabbedPage
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            Order o = BindingContext as Order;
            DisplayAlert("Order Placed",$"Order Placed for {o.Quantity} of {o.ProductName} and you rated for {o.Rating}", "OK");
        }
    }
}