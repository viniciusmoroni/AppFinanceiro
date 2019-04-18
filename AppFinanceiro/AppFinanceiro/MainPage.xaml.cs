using System;
using AppFinanceiro.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFinanceiro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Criar uma finança
            Financa obj = new Financa();
            obj.Descricao = "1 teste";
            obj.TipoOperacao = "Credito";
            obj.Valor = 200;
            obj.Data = DateTime.Now;

            App.TbFinancas.Inserir(obj);

            List<Financa> Financas = App.TbFinancas.Localizar();
            Lista.ItemsSource = Financas;
        }
    }
}
