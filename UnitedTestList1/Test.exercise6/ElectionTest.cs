using System.Collections.Generic;
using Xunit;

namespace Test.exercise6
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var candidates = new List<(int id, string name)>{(1, "José")};

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.Null(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (int id, string name) candidate = (1, "José");
            var candidates = new List<(int id, string name)>{candidate};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);
            
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal(candidate.id, election.Candidates[0].id);
            Assert.Equal(candidate.name, election.Candidates[0].name);
        }

        [Fact]
        public void should_return_same_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (int id, string name) candidate = (1, "José");
            (int id, string name) candidate2 = (2, "Ana");
            var candidates = new List<(int id, string name)>{candidate, candidate2};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            var result = election.ShowMenu();

            // Deve / Asserções
            Assert.Equal($"Vote {candidate.id} para o candidato: {candidate.name}", result[0]);
            Assert.Equal($"Vote {candidate2.id} para o candidato: {candidate2.name}", result[1]);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            (int id, string name) fernando = (1, "Fernando");
            (int id, string name) ana = (2, "Ana");
            var candidates = new List<(int id, string name)>{fernando, ana};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernando.id);
            election.Vote(fernando.id);

            // Deve / Asserções
            var candidateFernando = election.Candidates.Find(x => x.id == fernando.id);
            var candidateAna = election.Candidates.Find(x => x.id == ana.id);
            Assert.Equal(2, candidateFernando.votes);
            Assert.Equal(0, candidateAna.votes);
        }
    }
}