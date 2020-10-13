using System;
using Xunit;
using Domain;
using Should;
using System.Collections.Generic;

namespace Tests
{
    public class CandidateTest
    {
        // todo test for candidate

        [Fact]
        public void should_Save_Information_For_Candidate()
        {
            //Given
            var candidate = new Candidate("Jose", "910.371.860-36", 0);
            candidate.Vote();
            candidate.Vote();


            //Then
            Assert.NotNull(candidate);
            Assert.Equal(candidate.Votes, 2);
            candidate.Name.ShouldBeType(typeof(string));
            candidate.Cpf.ShouldBeType(typeof(string));
            candidate.Votes.ShouldBeGreaterThan(0);
            candidate.ShouldNotBeNull();
            
            
            

        }

    }
}



