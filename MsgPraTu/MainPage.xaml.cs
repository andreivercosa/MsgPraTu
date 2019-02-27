using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgPraTu
{

    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();


        }

        void Mensagem(object sender, EventArgs e)
        {

            List<String> lista = new List<String>();
            lista.Add("A persistência é o caminho do êxito");
            lista.Add("Só existe um êxito: a capacidade de levar a vida que se quer.");
            lista.Add("A coragem não é ausência do medo; é a persistência apesar do medo.");
            lista.Add("Só se pode alcançar um grande êxito quando nos mantemos fiéis a nós mesmos.");
            lista.Add("Creia em si, mas não duvide sempre dos outros.");

            Random random = new Random();
            texto.Text = lista[random.Next(0, lista.Count-1)];


        }
    }
}
