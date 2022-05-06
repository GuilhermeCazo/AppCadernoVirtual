using AppCadernoVirtual.Primeiro;
using AppCadernoVirtual.Segundo;
using AppCadernoVirtual.Terceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Aqui criamos uma função para quando o botão for clicado,
        //essa função fará o código toda as vezes que o manipulador
        //de eventos "Btn_1ano" for chamada, isso se procede com todos 
        
        
        private void Btn_1ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DisciplinasPrimeiro()); //Passamos aqui para a navegação
                                                             //de uma tela para a outra, nesse
                                                             //caso ela levará o usuário para
                                                             //uma página dentro de uma pasta
                                                             //no programa, por exemplo a página
                                                             //"DisciplinasPrimeiro" vai ser chamada
                                                             //e o usuário será levado para a página
                                                             //de disciplinas do primeiro ano


        }

        private void Btn_2ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DisciplinasSegundo());
        }

        private void Btn_3ano(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DisciplinasTerceiro());
        }
    }
}
