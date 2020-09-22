using System;
using Xunit;
using System.Collections.Generic;

namespace temp
{
    public class ElectionTest// criando o teste primeiro
    {
        [Fact]
        //não deve criar candidatos se a senha estiver errada
        public void Shold_Be_Not_created_Candidates_if_the_Pass_is_Incorrect()
        {
            //Given
            var created = new Election();
            var candidates = new List<(int id, string name)> { (1, "jose") };

            //Then
            var result = created.CreatedCandidates(candidates, "rewrwrwr");

            //When

            Assert.False(result);
        }
        [Fact]
        public void Shold_Be__created_Candidates_if_the_Pass_is_Correct()
        {
            //Given
            var election = new Election();
            (int id, string name) candidate = (1, "jose");
            var candidates = new List<(int id, string name)> { candidate };

            //When
            var result = election.CreatedCandidates(candidates, "CaDaStRaR"); // pass certo

            //Then
            Assert.True(election.Candidate.Count == 1);
            Assert.True(candidate.id == election.Candidate[0].id);
            Assert.True(candidate.name == election.Candidate[0].name);

        }


    }
}
