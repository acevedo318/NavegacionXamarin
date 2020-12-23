using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        async private void btnAnterior_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

        async private void btnInicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(true);
        }
    }
}