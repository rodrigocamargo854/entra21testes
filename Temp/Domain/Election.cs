
using System;
using System.Collections.Generic;
using System.Linq;


namespace Domain
{
    public class Election
    {



        // Esta propriedade tem a sua escrita privada, ou seja, ninguém de fora da classe pode alterar seu valor
        // Propriedade privada SEMPRE em camelcase
        private List<Candidate> candidates { get; set; }//para edição
        // Propriedade pública SEMPRE em PascalCase
        // Propriedade apenas com GET pode ser usada com arrow

        // para leitura e ainda sim ela ira retornar o candidates como proteção
        public IReadOnlyCollection<Candidate> Candidate { get { return candidates; } }
        // public IReadOnlyCollection<Candidate> Candidate => candidates; 

        public Election()
        {
            candidates = new List<Candidate>();
        }

        public bool CreateCandidates(List<Candidate> candidateNames, string password)
        {
            if (password == "Pa$$w0rd")
            {
                if (candidateNames == null)
                {
                    return true;
                }

                candidates = candidateNames;
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
            return candidates.First(x => x.Cpf == cpf).Id;

        }

        //    ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado

        public List<string> ReturnRepeatNames(List<string> name)
        {
            List<string> repeatNames = new List<string>();

            for (int i = 0; i < name.Count; i++)
            {
                if (candidates[i].Name == name[i])
                {
                    repeatNames.Add(candidates[i].Name);
                }

            }

            return repeatNames;
        }

        public Guid GetCandidateIdByName(string name) ///  nao precisa receber uma lista 
        {
            return candidates.First(x => x.Name == name).Id;
        }
        
        public bool Vote(string cpf)
        {
           var x = candidates.FirstOrDefault(candidates => candidates.Cpf == cpf);
           if(x == null)
           {
               return false;
           }

            x.Vote();
            return true;
        }


        public List<Candidate> GetWinners()
        {


            // winners receve uma lista que receberá os dados do candidato que estará na possicao 0(primeiro lugar)
            var winners = new List<Candidate> { candidates[0] };

            for (int i = 1; i < Candidate.Count; i++)
            {
                //se o candidatos que estiver no index  que for esta conter mais votos que o primeiro candidato
                if (candidates[i].Votes > winners[0].Votes)
                {
                    //limpa-se a lista winners
                    winners.Clear();
                    //adiciona o candidato em questao
                    winners.Add(candidates[i]);
                }

                //se o index que o for se encontra for igual ao numero de votos do primeiro candidato
                else if (candidates[i].Votes == winners[0].Votes)
                {

                    winners.Add(candidates[i]);
                }
            }
            return winners;

        }

        

    }
}

