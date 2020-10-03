
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Should;


namespace temp
{
    public class CandidateTest
    {
        // todo test for candidate

        [Fact]
        public void should_Save_Information_For_Candidate()
        {
            //Given
            var candidate = new Candidates("Name", "cpf", 0);
            candidate.Vote(candidate.Id);
            candidate.Vote(candidate.Id);



            //Then
            Assert.NotNull(candidate);
            Assert.Equal(candidate.Votes, 0);
            candidate.Name.ShouldBeType(typeof(string));
            candidate.Cpf.ShouldBeType(typeof(string));

        }








    }
}


