using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTesoura {
    public partial class FormJogo : Form
    {
        static readonly int PEDRA = 696969;
        static readonly int PAPEL = 585858;
        static readonly int TESOURA = 474747;

        int resultado = 0;
        int userPoints = 0;
        int computerPoints = 0;

        int escolhaDoUtilizador;
        int escolhaDoComputador;



        public FormJogo()
        {
            InitializeComponent();
        }


        //Metodos quando os botoes sao clicados
        private void buttonPedra_Click(object sender, EventArgs e) {
            choice(PEDRA);
        }

        private void buttonPapel_Click(object sender, EventArgs e) {
            choice(PAPEL);
        }

        private void buttonTesoura_Click(object sender, EventArgs e) {
            choice(TESOURA);
        }



        /**
         *  Metodo "principal"
         * 
         * */

        void choice(int escolhaDada) {

            //Escolha do utilizador
            escolhaDoUtilizador = escolhaDada;


            //Mudar de imagem consoante escolha --- Utilizador
            switch (escolhaDoUtilizador) {
                case 585858:
                    pictureBoxUser.Image = PedraPapelTesoura.Properties.Resources.PaperIconUser;
                    break;
                case 696969:
                    pictureBoxUser.Image = PedraPapelTesoura.Properties.Resources.RockIconUser;
                    break;
                case 474747:
                    pictureBoxUser.Image = PedraPapelTesoura.Properties.Resources.ScissorIconUser;
                    break;
                default:
                    //Nothing
                    break;
            }





            //Escolha do computador
            int x = new Random().Next(1, 103);
            if (x < 35) {
                escolhaDoComputador = PEDRA;
            } else if (x < 69) {
                escolhaDoComputador = PAPEL;
            } else {
                escolhaDoComputador = TESOURA;
            }


            //Mudar de imagem consoante escolha --- PC
            switch (escolhaDoComputador) {
                case 585858:
                    pictureBoxPC.Image = PedraPapelTesoura.Properties.Resources.PaperIconPC;
                    break;
                case 696969:
                    pictureBoxPC.Image = PedraPapelTesoura.Properties.Resources.RockIconPC;
                    break;
                case 474747:
                    pictureBoxPC.Image = PedraPapelTesoura.Properties.Resources.ScissorIconPC;
                    break;
                default:
                    //Nothing
                    break;
            }


            //Determinar o vencedor
            if (escolhaDoComputador == escolhaDoUtilizador) {
                resultado = 0;
            } else if (escolhaDoComputador == PEDRA) {
                if (escolhaDoUtilizador == TESOURA) {
                    resultado = 2;
                } else if (escolhaDoUtilizador == PAPEL) {
                    resultado = 1;
                }
            } else if (escolhaDoComputador == PAPEL) {
                if (escolhaDoUtilizador == PEDRA) {
                    resultado = 2;
                } else if (escolhaDoUtilizador == TESOURA) {
                    resultado = 1;
                }
            } else if (escolhaDoComputador == TESOURA) {
                if (escolhaDoUtilizador == PAPEL) {
                    resultado = 2;
                } else if (escolhaDoUtilizador == PEDRA) {
                    resultado = 1;
                }
            }

            //Alterar os pontos do vencedor
            if (resultado == 1) {
                userPoints = userPoints + 1;
            } else if (resultado == 2) {
                computerPoints = computerPoints + 1;
            }


            //Escrever quem é o vencedor
            if (resultado == 1) {
                labelGanhador.Text = "O User Ganhou!";
            } else if (resultado == 2) {
                labelGanhador.Text = "O PC Ganhou!";
            } else {
                labelGanhador.Text = "Foi um empate!";
            }

            //Escrever o resultado
            labelResultado.Text = "Resultado: " + userPoints + "(Tu) - " + computerPoints + "(PC)";





        }

    }
}
