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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, string edad, string pais, string ciudad, string montoinicial, string montomensual)
        {
            InitializeComponent();
            lblusuario.Text = "USUARIO CONECTADO: " + usuario;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad;
            txtPais.Text = pais;
            txtCiudad.Text = ciudad;
            txtMontoI.Text = montoinicial;
            txtMontoM.Text = montomensual;
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}