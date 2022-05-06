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
    public partial class DisciplinasTerceiro : ContentPage
    {
        public DisciplinasTerceiro()
        {
            InitializeComponent();
        }

        //ensino medio
        private void Btn_Por_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Por_3());
        }

        private void Btn_Mat_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Mat_3());
        }

        private void Btn_Bio_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Bio_3());
        }

        private void Btn_Fis_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Fis_3());
        }

        private void Btn_Qui_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Qui_3());
        }

        private void Btn_His_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.His_3());

        }
        private void Btn_Geo_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Geo_3());
        }

        private void Btn_Ing_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Ing_3());
        }

        private void Btn_Fil_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Fil_3());
        }

        private void Btn_Edf_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Edf_3());
        }

        private void Btn_Soc_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro.Soc_3());
        }

        //ensino tecnico









    }
}