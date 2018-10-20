using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private int i = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Botao_Clicked(object sender, EventArgs e)
        {
            //i++;
            //Button novoBotao = new Button();
            //novoBotao.Text = "Botão" + i;
            //novoBotao.Clicked += Botao_Clicked;
            //Stack.Children.Add(novoBotao);]
            
            var novaPagina = new Page1();
            await this.Navigation.PushAsync(novaPagina);
        }
    }
}
