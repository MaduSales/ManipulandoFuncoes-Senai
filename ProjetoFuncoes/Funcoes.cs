using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFuncoes
{
    public class Funcoes
    {
        double media;

        # region Método calcular média

        public double CalcularMedia(double parametro1, double parametro2, double parametro3) // "Void" significa que a função não tem retorno
        {
            media = (parametro1 + parametro2 + parametro3) / 3;

           return media; // "double" é o tipo de dado que será encapsulado dentro da função e será retornado
        }
        #endregion

        #region Método que verifica a situação do aluno
        public string VerificaSituacao(double mediaAluno)
        {
            if (mediaAluno >= 5)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
        #endregion
    }
}
