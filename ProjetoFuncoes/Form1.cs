using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double n1, n2, n3, media;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtNota1.Text);
            n2 = double.Parse(txtNota2.Text);
            n3 = double.Parse(txtNota3.Text);

            Funcoes obj = new Funcoes(); // obj é um item que vai referenciar o arquivo FUNCOES, podendo ser capaz de dar acesso às funções que estão no arquivo FUNCOES



            //OUTRAS FORMAS DE DECLARAR A FUNÇÃO DE CALCULAR A MÉDIA
            //media = obj.CalcularMedia(n1, n2, n3);
            // txtMedia.Text = media.ToString();
            txtMedia.Text = obj.CalcularMedia(n1, n2, n3).ToString();


            //OUTRAS FORMAS DE DECLARAR A FUNÇÃO VERIFICAÇÃO DE SITUAÇÃO
            //lblSituacao.Text = obj.VerificaSituacao(media)
            lblSituacao.Text = obj.VerificaSituacao(obj.CalcularMedia(n1, n2, n3)); 
        }
    }
}
