using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AppClima
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new Clima();
        }

        public async void btnBuscar_Clicked(object sender ,EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCiudad.Text))
            {
                var clima = await ServicioClima.ConsultarClima(txtCiudad.Text);

                if (clima != null)
                {
                    this.BindingContext = clima;
                    btnBuscar.Text = "Buscar de Nuevo";
                }

            }
        }
    }
}
