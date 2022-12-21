using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDeEnvioDeEmail
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btEnviar_Clicked(object sender, EventArgs e)
        {           
            string des = etDest.Text;
            string ass = etAssum.Text;
            string texto = etTexto.Text;

            string url = "mailto:" + des + "?subject=" + ass + "&body=" + texto;
            Device.OpenUri(new Uri(url));
        }
    }
}
