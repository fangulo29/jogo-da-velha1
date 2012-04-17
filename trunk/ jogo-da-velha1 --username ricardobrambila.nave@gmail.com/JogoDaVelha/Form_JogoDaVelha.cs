using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form_JogoDaVelha : Form
    {
        string nome_Jogador1;
        string nome_Jogador2;
        //string jogada;

        int contador = 0;
        int pJogador1 = 0;
        int pJogador2 = 0;
        int empates = 0;

        bool ganhou = false;
        bool escolheuX = true; // Variável que diz quem venceu *comentar melhor depois*.
        bool jogaContra2 = true;

        public Form_JogoDaVelha()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Caso o jogador clique no "X" da tela, uma mensagem apaerecerá.
            if (MessageBox.Show("Deseja fechar o jogo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            // Uma mensagem igual a função de cima aparecerá caso o jogador clique no botão Sair.
            Close();
        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            if ((tb_Jogador.Text != "") && (tb_Jogador2.Text != ""))
            {
                // A variável string nome_Jogador1 será igual ao texto que será escrito na caixa branca (tb_Jogador).
                nome_Jogador1 = tb_Jogador.Text;
                tb_Jogador.Visible = false;

                // O mesmo a cima.
                nome_Jogador2 = tb_Jogador2.Text;
                tb_Jogador2.Visible = false;

                // A label invisível atrás de nome_Jogador1 será escrita na tela
                lb_jogador.Text = nome_Jogador1 + " joga com ";
                lb_jogador2.Text = nome_Jogador2 + " joga com ";

                // Escrever se o jogador 1 X ou O e ja escolhendo automaticamente a opção do jogador 2.
                if (rb_X.Checked)
                    lb_jogador.Text = lb_jogador.Text + "X";
                else if (rb_O.Checked)
                    lb_jogador.Text = lb_jogador.Text + "O";

                if (rb_X.Checked)
                {
                    lb_jogador2.Text = lb_jogador2.Text + "O";
                    escolheuX = true;
                }
                else if (rb_O.Checked)
                {
                    lb_jogador2.Text = lb_jogador2.Text + "X";
                    escolheuX = false;
                }

                /*
                 * Se o jogador iniciar o jogo, ele nao poderá mais alterar sua jogada (X ou O),
                 * poderá começar a clicar nos botoes do jogo e nao poderá clicar em iniciar novamente.
                */
                gb_opcoes.Enabled = false;
                panel_bottom.Enabled = true;
                bt_iniciar.Enabled = false;
            }
            else
                MessageBox.Show("Informe os nomes do jogadores." , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            /*
             * Se o jogador clicar no botao 01, a sua opção de jogo será escrita em bt1.Text,
             * e o jogador não poderá clicar no mesmo botão novamente.
            */
            if (rb_X.Checked) // botao 01
            {
                bt1.Text = rb_X.Text;
                rb_O.Checked = true;
                bt1.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt1.Text = rb_O.Text;
                rb_X.Checked = true;
                bt1.Enabled = false;
            }
            // Chama a função vencedor para verificar se o jogador já teria ganho o jogo e faz a contagem.
            contador++;
            vencedor();

            // A mesma coisa acontece nos outros botões.
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 02
            {
                bt2.Text = rb_X.Text;
                rb_O.Checked = true;
                bt2.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt2.Text = rb_O.Text;
                rb_X.Checked = true;
                bt2.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 03
            {
                bt3.Text = rb_X.Text;
                rb_O.Checked = true;
                bt3.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt3.Text = rb_O.Text;
                rb_X.Checked = true;
                bt3.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 04
            {
                bt4.Text = rb_X.Text;
                rb_O.Checked = true;
                bt4.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt4.Text = rb_O.Text;
                rb_X.Checked = true;
                bt4.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 05
            {
                bt5.Text = rb_X.Text;
                rb_O.Checked = true;
                bt5.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt5.Text = rb_O.Text;
                rb_X.Checked = true;
                bt5.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 06
            {
                bt6.Text = rb_X.Text;
                rb_O.Checked = true;
                bt6.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt6.Text = rb_O.Text;
                rb_X.Checked = true;
                bt6.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 07
            {
                bt7.Text = rb_X.Text;
                rb_O.Checked = true;
                bt7.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt7.Text = rb_O.Text;
                rb_X.Checked = true;
                bt7.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 08
            {
                bt8.Text = rb_X.Text;
                rb_O.Checked = true;
                bt8.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt8.Text = rb_O.Text;
                rb_X.Checked = true;
                bt8.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked) // botao 09
            {
                bt9.Text = rb_X.Text;
                rb_O.Checked = true;
                bt9.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                bt9.Text = rb_O.Text;
                rb_X.Checked = true;
                bt9.Enabled = false;
            }
            contador++;
            vencedor();
        }

        private void bt_reiniciar_Click(object sender, EventArgs e)
        {
            // Caso o jogador queira reiniciar, tudo voltará ao começo.
            habilitar_Botoes();
            limpar_Botoes();
            panel_bottom.Enabled = true;
            contador = 0;
            ganhou = false;
        }

        public void vencedor()
        {
            // Verificação de vitória caso três botoes horizontais tenham o mesmo rb_X.Text.
            // Agora, ele tbm verifica se o jogador começou o jogo com X ou O com o uso da variavel escolheuX. 
            if (
                (bt1.Text == rb_X.Text && bt2.Text == rb_X.Text && bt3.Text == rb_X.Text) ||
                (bt4.Text == rb_X.Text && bt5.Text == rb_X.Text && bt6.Text == rb_X.Text) ||
                (bt7.Text == rb_X.Text && bt8.Text == rb_X.Text && bt9.Text == rb_X.Text)
               )
            {
                if (escolheuX == true)
                {
                    // Da a mensagem de quem ganhou, o jogador nao poderá clicar em mais nenhum botão
                    // do painel de baixo e ganhou fica true, ou seja, mesmo o jogador ganhe com
                    // contador igual a 09, esta mensagem aparecerá.
                    MessageBox.Show(nome_Jogador1 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador1 ++;
                }
                else if (escolheuX == false)
                {
                    MessageBox.Show(nome_Jogador2 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador2 ++;
                }
             
            }

            if (
                (bt1.Text == rb_O.Text && bt2.Text == rb_O.Text && bt3.Text == rb_O.Text) ||
                (bt4.Text == rb_O.Text && bt5.Text == rb_O.Text && bt6.Text == rb_O.Text) ||
                (bt7.Text == rb_O.Text && bt8.Text == rb_O.Text && bt9.Text == rb_O.Text)
               )
            {
                if (escolheuX == true)
                {
                    MessageBox.Show(nome_Jogador2 + " Ganhou!!!", "Parabéns");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador2++;
                }
                else if (escolheuX == false)
                {
                    MessageBox.Show(nome_Jogador1 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador1++;
                }
            }

            // Verificação vertical.
            if (
                (bt1.Text == rb_X.Text && bt4.Text == rb_X.Text && bt7.Text == rb_X.Text) ||
                (bt2.Text == rb_X.Text && bt5.Text == rb_X.Text && bt8.Text == rb_X.Text) ||
                (bt3.Text == rb_X.Text && bt6.Text == rb_X.Text && bt9.Text == rb_X.Text)
               )
            {
                if (escolheuX == true)
                {
                    MessageBox.Show(nome_Jogador1 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador1++;
                }
                else if (escolheuX == false)
                {
                    MessageBox.Show(nome_Jogador2 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador2++;
                }
            }

            if (
                (bt1.Text == rb_O.Text && bt4.Text == rb_O.Text && bt7.Text == rb_O.Text) ||
                (bt2.Text == rb_O.Text && bt5.Text == rb_O.Text && bt8.Text == rb_O.Text) ||
                (bt3.Text == rb_O.Text && bt6.Text == rb_O.Text && bt9.Text == rb_O.Text)
               )
            {
                if (escolheuX == true)
                {
                    MessageBox.Show(nome_Jogador1 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador2++;
                }
                else if (escolheuX == false)
                {
                    MessageBox.Show(nome_Jogador2 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador1++;
                }
            }

            // Verificação cruzada.
            if (
                (bt1.Text == rb_X.Text && bt5.Text == rb_X.Text && bt9.Text == rb_X.Text) ||
                (bt3.Text == rb_X.Text && bt5.Text == rb_X.Text && bt7.Text == rb_X.Text)
               )
            {
                if (escolheuX == true)
                {
                    MessageBox.Show(nome_Jogador1 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador1++;
                }
                else if (escolheuX == false)
                {
                    MessageBox.Show(nome_Jogador2 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador2++;
                }
            }

            if (
                (bt1.Text == rb_O.Text && bt5.Text == rb_O.Text && bt9.Text == rb_O.Text) ||
                (bt3.Text == rb_O.Text && bt5.Text == rb_O.Text && bt7.Text == rb_O.Text)
               )

            {
                if (escolheuX == true)
                {

                    MessageBox.Show(nome_Jogador1 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador2++;
                }
                else if (escolheuX == false)
                {
                    MessageBox.Show(nome_Jogador2 + " Ganhou", "Parabéns!!!");
                    panel_bottom.Enabled = false;
                    ganhou = true;
                    pJogador1++;
                }
            }

            // Se ao clicar no 9º botao o jogo nao tenha um vencedor a label empates adicionará
            // mais 01 ao seu int.
            if (contador == 9 && ganhou == false)
            {
                empates++;
                lb_empate.Text = empates.ToString() + " - Empate(s)";
                MessageBox.Show("Empatou Noob!!");
            }

            // Escrita do placar nas labels vazias do painel placar.
            lb_PJogador1.Text = pJogador1 + " - Vitória(s)";
            lb_PJogador2.Text = pJogador2 + " - Vitória(s)";
        }

        public void limpar_Botoes()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
        }

        public void habilitar_Botoes()
        {
            // Função para habilitar o clique de botoes, pois ao clicar em qualquer botao ele é automaticamente desabilitado.
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt9.Enabled = true;
        }

        private void p2_cpu_Click(object sender, EventArgs e)
        {
            if (jogaContra2 == true)
            {
                p2_cpu.Text = "2 Player";
                jogaContra2 = false;
            }
            else if (jogaContra2 == false)
            {
                p2_cpu.Text = "CPU";
                jogaContra2 = true;
            }
        }

    }
}
