
using System.Linq;
using System;   
using System.Collections.Generic;
namespace temp
{
    public class Candidates
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }  

        public int Votes { get; set;}


        public Candidates(string name,string cpf)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cpf = cpf;      
        } 

        public void ClassCreateCandidates(string cand1,string cpf1,string cand2,string cpf2)
        {
            var election = new Election();
            (string candidateName, string cpf, int votes) candidate1 = (cand1, cpf1, 0);
            (string candidateName, string cpf, int votes) candidate2 = (cand2, cpf2, 0);

            var candidates = new List<(string name, string cpf, int votes)> { (candidate1), (candidate2) };

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");
            var input = new List<string> { "José", "Maria" };
        }
    }
}