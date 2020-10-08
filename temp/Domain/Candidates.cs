
using System.Linq;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Candidates
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public int Votes { get; private set; }



        public Candidates(string name, string cpf, int votes)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cpf = cpf;
            Votes = votes;
        }

        public void Vote()
        {
            Votes++;
        }


    }
}