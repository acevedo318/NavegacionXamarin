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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async private void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page3(), true);
        }

        async private void btnAnterior_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}