
using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<Candidates> Candidates { get; private set; }

        public bool CreateCandidates(List<Candidates> candidateNames, string password)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidateNames;
                return true;
            }

            else
            {
                return false;
            }

        }

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF
        public Guid GetCandidateIdBycpf(string cpf)
        {
            return Candidates.Find(x => x.Cpf == cpf).Id;

        }

        //    ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado

        public List<string>  ReturnRepeatNames (List<string> name)
        {
            List<string> repeatNames = new List<string>();

            for (int i = 0; i < name.Count; i++)
            {
                if(Candidates[i].Name == name[i])
                {
                    repeatNames.Add(name[i]);
                }    

            }

            return repeatNames;

        }

        public Guid GetCandidateIdByName(List<Candidates> candidatesList, string name)
        {
            return candidatesList.First(x => x.Name == name).Id;
        }
           public void Vote(Guid id)
        {
            Candidates.First(candidates => candidates.Id == id).Votes++;
        }

      

        public List<Candidates> GetWinners()
        {   
            // winners receve uma lista que receberá os dados do candidato que estará na possicao 0(primeiro lugar)
            var winners = new List<Candidates> { Candidates[0] };

            for (int i = 1; i < Candidates.Count; i++)
            {   
                //se o candidatos que estiver no index  que for esta conter mais votos que o primeiro candidato
                if (Candidates[i].Votes > winners[0].Votes)
                {
                    //limpa-se a lista winners
                    winners.Clear();
                    //adiciona o candidato em questao
                    winners.Add(Candidates[i]);
                }

                //se o index que o for se encontra for igual ao numero de votos do primeiro candidato
                else if (Candidates[i].Votes == winners[0].Votes)
                {
                    
                    winners.Add(Candidates[i]);
                }
            }
            return winners;

        }


    }
}
