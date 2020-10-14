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
        // não gerar o mesmo id para os dois candidatos
        [Fact]
        public void Should_not_generate_same_id_for_both_candidates()
        {
            var Jose = new Candidate("José", "895.456.214-78", 0);
            var Ana = new Candidate("Ana", "456.456.214-78", 0);

            Assert.NotEqual(Jose.Id, Ana.Id);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("000.000.000-00")]
        [InlineData("000.000.000-01")]
        [InlineData("111.111.111-11")]
        [InlineData("999.999.999-99")]
        [InlineData("000.368.560-00")]
        [InlineData("640.3685606")]
        [InlineData("640.368.560-6")]
        [InlineData("640.368.560-6a")]
        [InlineData("640.368.560-061")]

        public void Should_return_false_when_CPF_is_invalid(string CPF)
        {
            // Dado / Setup
            var Jose = new Candidate("José", CPF, 0);

            // When / Ação
            var isValid = Jose.Validate();

            // Deve / Asserções
            Assert.False(isValid);
        }

        [Theory]
        [InlineData("64036856006")]
        [InlineData("640.368.560-06")]
        public void Should_return_true_when_CPF_is_valid(string CPF)
        {
            // Dado / Setup
            var Jose = new Candidate("José", CPF, 0);

            // When / Ação
            var isValid = Jose.Validate();

            // Deve / Asserções
            Assert.True(isValid);
        }


        [Theory]
        [InlineData("José55", "29850388803")]
        [InlineData("Maria55", "298503888-03")]

        public void Should_return_False_When_Candidate_Is_Invalid(string name, string cpf)
        {
            // Dado / Setup
            var Jose = new Candidate(name, cpf, 0);

            // When / Ação
            var isValid = Jose.Validate();

            // Deve / Asserções
            Assert.False(isValid);

        }

        [Theory]
        [InlineData("Maria Fernanda")]
        [InlineData("Jose")]
        public void Should_return_True_When_Candidate_Is_valid(string name)
        {
            // Dado / Setup
            var Jose = new Candidate(name, "2985-03888-03", 0);

            // When / Ação
            var isValid = Jose.Validate();

            // Deve / Asserções
            Assert.True(isValid);


        }
    }


}



