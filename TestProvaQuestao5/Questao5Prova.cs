using System;
using System.Collections.Generic;
using System.Text;

namespace TestProvaQuestao5 
{
    public class Questao5Prova 
    {
        public List<double?> Questao5 (params double?[] input)

        {
            var numbers = new List<double?>();

           foreach (var item in input)
           {
               if(item != null)
               {
                   numbers.Add(item);
               }
               
           }

            return numbers;

        }

    }
}