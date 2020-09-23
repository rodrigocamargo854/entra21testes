
using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
  public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        public List<(Guid id, string name, string cpf, int votes)> Candidates { get; set; }
        
        public bool CreateCandidates(List<(string names, string cpf)> candidateNames, string password)
        {
            if (password == "Pa$$w0rd")
            {
                Candidates = candidateNames.Select(candidateName => {
                    return (Guid.NewGuid(), candidateName.names,candidateName.cpf, 0);
                }).ToList();

                return true;
            }

            else
            {
                return false;
            }
        }

       

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF
        // public Guid ReturnCandidateByCpf(string cpf)

        // {
            
        // }


        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        // public List<string>  ReturnRepeatNames (List<(string name, string cpf)> candidates)
        // {
        //     List<string> repeatNames = new List<string>();

        //     for (int i = 0; i < candidates.Count; i++)
        //     {
        //         repeatNames = candidates.Where(item => item.name == candidates[i].name);
        //     }

        //     return repeatNames;

        // }

       public Guid GetCandidateIdByName(string name, string cpf)
        {
            return Candidates.First(x => x.name == name).id;
        }
        
        // public void Vote(Guid id)
        // {
        //     Candidates = Candidates.Select(candidate => {
        //         return candidate.id == id ? (Guid.NewGuid(), 
        //         candidate.name, candidate.cpf, candidate.votes + 1)
        //         : candidate;
        //     }).ToList();
        // }

    //     public List<(Guid id, string name,string cpf, int votes)> GetWinners()
    //     {
    //         var winners = new List<(Guid id, string name,string cpf, int votes)>{Candidates[0]};

    //         for (int i = 1; i < Candidates.Count; i++)
    //         {
    //             if (Candidates[i].votes > winners[0].votes)
    //             {
    //                 winners.Clear();
    //                 winners.Add(Candidates[i]);
    //             }
    //             else if (Candidates[i].votes == winners[0].votes)
    //             {
    //                 winners.Add(Candidates[i]);
    //             }
    //         }
    //         return winners;
    //     }
     }


}