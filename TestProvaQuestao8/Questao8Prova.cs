
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProvaQuestao8
{
    public class Questao8Prova
    {
        public  string Questao8 (string[] vesp , string[] mat)

        {
            string alunos = "";

            for (int i = 0; i < vesp.Length; i++) 
            {
               for (int j = 0; j < mat.Length; j++)
               {
                   if(vesp [j] == mat[i])
                   {
                       alunos += ($"{mat[i]} ");
                   }
               }
            }

            return alunos;

        }
        
    }
}