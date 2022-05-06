using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadernoVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisciplinasSegundo : ContentPage
    {
        public DisciplinasSegundo()
        {
            InitializeComponent();
        }

        private void Btn_Por_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Por_2());
        }

        private void Btn_Mat_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Mat_2());
        }

        private void Btn_Bio_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Bio_2());
        }

        private void Btn_Fis_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Fis_2());
        }

        private void Btn_Qui_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Qui_2());
        }

        private void Btn_His_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.His_2());
        }

        private void Btn_Geo_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Geo_2());
        }

        private void Btn_Ing_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Ing_2());
        }

        private void Btn_Edf_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Edf_2());
        }

        private void Btn_Fil_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Fil_2());

        }

        private void Btn_Eti_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Eti_2());

        }

        private void Btn_Soc_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo.Soc_2());

        }


    }
}