using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ClsCNH
{
    /// <summary>
    /// Metodo para validar se o CNH é valido
    /// </summary>
    /// <param name="CNH">Entrada do numero do CNH 9 numeros e 2 digitos verificadores </param>
    /// <returns></returns>
    public static bool ValidarCNH(string CNH)
    {
        #region variaveis
        double soma = 0.0;
        double digito = 0.0; // digito pegado pelo substring
        double digito1Verificador = 0.0;
        double digito2Verificador = 0.0;
        double resto = 0.0;
        int cont = 0;
        bool excecao = false;
        #endregion

        #region Primeiro Digito
        for (int i = 9; i > 0; i--) // for para fazer a multiplicação e a soma 
        {
            digito = double.Parse(CNH.Substring(cont, 1)); // recebimento do digito e transformação em double
            soma += digito * i; // multiplicação consiste em pegar os primeiros 9 digitos e multiplicar por 9 a 1
            cont++;
        }
        resto = soma % 11; // o resto da divisão da soma por 11 
        excecao = resto>9? true:false; // caso o resto seja maior que nove vai ativar a regra diferenciada
        digito1Verificador = resto > 9 ? 0 : resto; // se resto for maior que nove o digito vira 0 senão o resto é o digito
        soma = 0;
        #endregion

        #region Segundo Digito
        for (int i = 0; i < 9; i++) // for para fazer a multiplicação e a soma 
        {
            digito = double.Parse(CNH.Substring(i, 1)); // recebimento do digito e transformação em double
            soma += digito * (i + 1); // multiplicação consiste em pegar os primeiros 9 digitos e multiplicar por 1 a 9
        }
        resto = soma % 11; // o resto da divisão da soma por 11 é o digito
        digito2Verificador = resto > 9 ? 0 : resto; // se resto for maior que nove o digito vira 0
        if (excecao) // exceção se o resto do primeiro for maior que nove ele entra na exceção
        {
            if(digito2Verificador-2 < 0)
            {
                digito2Verificador += 9; 
            }
            else
            {
                digito2Verificador -= 2;
            }
        }
        
        #endregion

        

        #region Validação 
        if (digito1Verificador.ToString() == CNH.Substring(9, 1)) // validação se os digitos batem com o do CNH digitado
        {
            if (digito2Verificador.ToString() == CNH.Substring(10, 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
        #endregion



    }
}

