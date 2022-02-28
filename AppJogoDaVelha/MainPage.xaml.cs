using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        bool vitoria;
        string vez = "x";

        public void reset_game()
        {
            bnt1.Text = "";
            bnt1.IsEnabled = true;
            bnt2.Text = "";
            bnt2.IsEnabled = true;
            bnt3.Text = "";
            bnt3.IsEnabled = true;
            bnt4.Text = "";
            bnt4.IsEnabled = true;
            bnt5.Text = "";
            bnt5.IsEnabled = true;
            bnt6.Text = "";
            bnt6.IsEnabled = true;
            bnt7.Text = "";
            bnt7.IsEnabled = true;
            bnt8.Text = "";
            bnt8.IsEnabled = true;
            bnt9.Text = "";
            bnt9.IsEnabled = true;

            vitoria = false;
        }

        public void testWin()
        {
            if (bnt1.Text == vez && bnt2.Text == vez && bnt3.Text == vez) {
                vitoria = true;
            } else if (bnt4.Text == vez && bnt5.Text == vez && bnt6.Text == vez) {
                vitoria = true;
            } else if (bnt7.Text == vez && bnt8.Text == vez && bnt9.Text == vez) {
                vitoria = true;
            } else if (bnt1.Text == vez && bnt4.Text == vez && bnt7.Text == vez) {
                vitoria = true;
            } else if (bnt2.Text == vez && bnt5.Text == vez && bnt8.Text == vez) {
                vitoria = true;
            } else if (bnt3.Text == vez && bnt6.Text == vez && bnt9.Text == vez) {
                vitoria = true;
            } else if (bnt1.Text == vez && bnt5.Text == vez && bnt9.Text == vez) {
                vitoria = true;
            } else if (bnt7.Text == vez && bnt5.Text == vez && bnt3.Text == vez) {
                vitoria = true;
            }
        }

        private void charge_theme(object sender, EventArgs e) {
            if (fundo.BackgroundColor == Color.White)
            {
                button_theme.Text = "Ativar White!";
                fundo.BackgroundColor = Color.Black;
                title.TextColor = Color.White;
                label_vez.TextColor = Color.White;
            } else
            {
                button_theme.Text = "Ativar Black!";
                fundo.BackgroundColor = Color.White;
                title.TextColor = Color.Black;
                label_vez.TextColor = Color.Black;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bnt = (Button)sender; // Evento "sender" pega o botão que o usuário clicou.

            if (vez == "x")
            {
                bnt.Text = "x"; // Adiciona um texto ao botão;
                bnt.IsEnabled = false; // Impossibilita o botão de ser clicado;
                testWin();
                vez = "o";
                label_vez.Text = "É a vez do " + vez.ToUpper();

                if (vitoria == true) {
                    reset_game();
                    DisplayAlert("👑 Mensagem do Vencedor!", "O Jogador \"X\" ganhou!", "Jogar Novamente.");
                } else if (bnt1.IsEnabled == false && bnt2.IsEnabled == false && bnt3.IsEnabled == false && bnt4.IsEnabled == false && bnt5.IsEnabled == false && bnt6.IsEnabled == false && bnt7.IsEnabled == false && bnt8.IsEnabled == false && bnt9.IsEnabled == false) {
                    reset_game();
                    DisplayAlert("Mensagem do Sistema!", "O Jogo deu VELHA!", "Jogar Novamente.");
                }

                //if (bnt1.IsEnabled == false && bnt2.IsEnabled == false && bnt3.IsEnabled == false && bnt4.IsEnabled == false && bnt5.IsEnabled == false && bnt6.IsEnabled == false && bnt7.IsEnabled == false && bnt8.IsEnabled == false && bnt9.IsEnabled == false) label.Text = "Deu Velha!";
            }
            else
            {
                bnt.Text = "o";
                bnt.IsEnabled = false;
                testWin();
                vez = "x";
                label_vez.Text = "É a vez do " + vez.ToUpper();

                if (vitoria == true) {
                    reset_game();
                    vez = "o";
                    DisplayAlert("👑 Mensagem do Vencedor!", "O Jogador \"O\" ganhou!", "Jogar Novamente.");
                } else if (bnt1.IsEnabled == false && bnt2.IsEnabled == false && bnt3.IsEnabled == false && bnt4.IsEnabled == false && bnt5.IsEnabled == false && bnt6.IsEnabled == false && bnt7.IsEnabled == false && bnt8.IsEnabled == false && bnt9.IsEnabled == false) {
                    reset_game();
                    DisplayAlert("Mensagem do Sistema!", "O Jogo deu VELHA!", "Jogar Novamente.");
                }

                //if (bnt1.IsEnabled == false && bnt2.IsEnabled == false && bnt3.IsEnabled == false && bnt4.IsEnabled == false && bnt5.IsEnabled == false && bnt6.IsEnabled == false && bnt7.IsEnabled == false && bnt8.IsEnabled == false && bnt9.IsEnabled == false) label.Text = "Deu Velha!";
            }
        }
    }
}
