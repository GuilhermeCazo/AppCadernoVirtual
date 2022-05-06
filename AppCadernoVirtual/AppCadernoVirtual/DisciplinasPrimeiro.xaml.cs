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
    public partial class DisciplinasPrimeiro : ContentPage
    {
        public DisciplinasPrimeiro()
        {
            InitializeComponent();
        }

        private void Btn_Por_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Por_1());
        }

        private void Btn_Mat_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Mat_1());
        }

        private void Btn_Bio_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Bio_1());
        }

        private void Btn_Fis_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Fis_1());
        }

        private void Btn_Qui_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Qui_1());
        }
        private void Btn_His_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.His_1());
        }

        private void Btn_Geo_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Geo_1());
        }

        private void Btn_Ing_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Ing_1());
        }

        private void Btn_Fil_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Fil_1());
        }

        private void Btn_Edf_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.EdF_1());
        }

        private void Btn_Art_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Art_1());
        }

        //curso

        private void Btn_Aps_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Aps_1());
        }
        private void Btn_Pw1_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Pw1_1());
        }
        private void Btn_Bd1_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Bd1_1());
        }
        private void Btn_Dsg_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Dsg_1());
        }
        private void Btn_Fdi_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Fdi_1());
        }

        private void Btn_Lpa_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro.Lpa_1());
        }
    }
}