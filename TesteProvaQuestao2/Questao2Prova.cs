namespace TesteProvaQuestao2
{
    public class Questao2Prova
    {

         public string  Questao2(string[] x,int times )
        {

            string phrase = "";

                for(int i = 0; i <= times; i++)
               {

                phrase += x[i];

               }    

               return phrase;
 
        }

        
        
    }
}