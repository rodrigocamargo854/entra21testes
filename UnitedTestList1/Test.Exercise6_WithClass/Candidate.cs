using System;
using System.Linq;


namespace Test.Exercise6_WithClass
{
    public class Candidate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Cpf { get; set; }

        public int Votes { get; set; }

        

        public Candidate(Guid id, string name, string cpf, int votes)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Votes = votes;
        }
    }
}
