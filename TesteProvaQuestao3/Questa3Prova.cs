using System;
using System.Collections.Generic;
using System.Text;

namespace TesteProvaQuestao3
{
    public class Questao3Prova 
    {

        public string Questao3 ( (string names, string answers)[] men)

        {
            var singles = new StringBuilder();//poderia utilizar tb string singles = ""
            // var singles = new string[5];

            for (int i = 0; i < 3; i++)

                if (men[i].answers == "yes" || men[i].answers == "YES") 
                {
                    singles.Append($"{men[i].names} ");//singles += <<<tb poderia utilizar
                }

            return singles.ToString();
        }

    }

}