using System;
using Xunit;
using Domain;

namespace Tests
{
    public class CandidateTest
    {
        // todo test for candidate

        [Fact]
        public void should_Save_Information_For_Candidate()
        {
            //Given
            var candidate = new Candidates("Name", "cpf", 0);
            candidate.Vote();
            candidate.Vote();


            //Then
            Assert.NotNull(candidate);
            Assert.Equal(candidate.Votes, 2);
            candidate.Name.ShouldBeType(typeof(string));
            candidate.Cpf.ShouldBeType(typeof(string));

        }

    }
}

