using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void GoToPage2(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new Page2(), true);
        }
    }
}
