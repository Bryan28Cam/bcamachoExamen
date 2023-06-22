using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bcamachoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = "USUARIO CONECTADO: " + usuario;
            this.usuario = usuario;
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            String nombre = (txtNombre.Text);
            String apellido = (txtApellido.Text);
            String edad = (txtEdad.Text);
            string pais = pkPais.Items[pkPais.SelectedIndex];
            string ciudad = pkCiudades.Items[pkCiudades.SelectedIndex];
            string montoinicial = (txtMontoI.Text);
            string montomensual = (txtMontoM.Text);

            Navigation.PushAsync( new Resumen(usuario, nombre, apellido, edad, pais, ciudad, montoinicial, montomensual));
        }
    }
}