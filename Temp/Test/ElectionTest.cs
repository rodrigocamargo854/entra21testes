using System;
using Xunit;
using Domain;
using System.Collections.Generic;
using System.Linq;
using Should;

namespace Tests
{
    public class ElectionTest
    {
        //todo a test for receive null candidate

        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            //Given
            var election = new Election();// cria-se obejto Election
            // candidates armazena os dados do candidato que deseja-se criar

            var candidateRodrigo = new Candidate("Rodrigo", "642.682.750-96", 0);
            var candidateMaria = new Candidate("Maria", "008.682.770-70", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };


            // Then // acessa o metodo CreateCandidates por meio do selection, com os dados e o pass
            var created = election.CreateCandidates(cantidatesList, "incorrect");

            // When // assegura-se que não criou nenhum candidato
            Assert.Empty(election.Candidate);
            Assert.False(created);

        }



        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            //Given
            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "642.682.750-96", 0);
            var candidateMaria = new Candidate("Maria", "400.303.750-29", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };



            // When //acessa o metodo CreateCandidates por meio do selection, com os dados e o pass
            var created = election.CreateCandidates(cantidatesList, "Pa$$w0rd");

            // Then // candidatos devem ser criados
            Assert.True(created);

            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.True(election.Candidate.Count == 2);
            //assegura que a pos 0 nome e igual ao nome do candidato 1
            Assert.True(election.Candidate.ElementAt(0).Name == candidateRodrigo.Name);
            //assegura q a pos 1 do noome e igual ao nome do candidato2
            Assert.True(election.Candidate.ElementAt(1).Name == candidateMaria.Name);
            //asegura que os nomes são diferentes
            Assert.True(election.Candidate.ElementAt(1).Name != election.Candidate.ElementAt(0).Name);
            //assegura que os candidatos não possuem votos
            Assert.True(election.Candidate.ElementAt(1).Votes == 0);
            Assert.True(election.Candidate.ElementAt(0).Votes == 0);
            //assegura que os ids são diferentes
            Assert.True(election.Candidate.ElementAt(1).Id != election.Candidate.ElementAt(0).Id);
            Assert.True(election.Candidate.ElementAt(1).Id != election.Candidate.ElementAt(0).Id);


        }

        [Fact]
        public void should_return_different_ids()
        {
            //Given
            var election = new Election();
            var candidateJose = new Candidate("José", "588.998.190-00", 0);
            var candidateMaria = new Candidate("Maria", "400.303.750-29", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateJose, candidateMaria
            };

            //When

            var candidates = election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var joseId = election.GetCandidateIdByName("José");
            var mariaId = election.GetCandidateIdByName("Maria");

            //Then
            Assert.NotEqual(joseId, mariaId);


        }
        [Fact]
        public void should_vote_twice_in_candidate_Jose()
        {

            //Given
            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "456.785.500-04", 0);
            var candidateMaria = new Candidate("Maria", "588.998.190-09", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos
                                                                   //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var rodrigoId = election.GetCandidateIdByName("Rodrigo");
            var mariaId = election.GetCandidateIdByName("Maria");

            //when
            candidateRodrigo.Vote();
            candidateRodrigo.Vote();

            // election.Vote(election.Candidates.ElementAt(0).Id);
            // election.Vote(election.Candidates.ElementAt(0).Id);

            //Then
            Assert.Equal(2, election.Candidate.ElementAt(0).Votes);
            Assert.Equal(0, election.Candidate.ElementAt(1).Votes);

        }

        [Fact]
        public void should_return_Rodrigo_as_winner_when_only_Rodrigo_receives_votes()
        {
            //Given
            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "456.785.500-04", 0);
            var candidateMaria = new Candidate("Maria", "450.303.280-17", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos
                                                                   //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var rodrigoId = election.GetCandidateIdByName("Rodrigo");
            var mariaId = election.GetCandidateIdByName("Maria");

            // Given
            candidateRodrigo.Vote();
            candidateRodrigo.Vote();

            // election.Vote(election.Candidates.ElementAt(0).Id);
            // election.Vote(election.Candidates.ElementAt(0).Id);
            // When

            var winners = election.GetWinners();

            //Then
            Assert.True(winners.Count == 1);
            Assert.Equal(election.Candidate.ElementAt(0).Id, winners[0].Id);
            Assert.Equal(2, winners[0].Votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "922.736.560-500", 0);
            var candidateMaria = new Candidate("Maria", "450.303.280-17", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            var rodrigoId = election.GetCandidateIdByName("Rodrigo");
            var mariaId = election.GetCandidateIdByName("Maria");
            //To vote
            candidateRodrigo.Vote();
            candidateMaria.Vote();

            // Quando / Ação
            var winners = election.GetWinners();

            // Deve / Asserções

            Assert.Equal(election.Candidate.ElementAt(0).Id, winners[0].Id);
            Assert.Equal(election.Candidate.ElementAt(1).Id, winners[1].Id);
            Assert.Equal(election.Candidate.ElementAt(0).Votes, 1);

            //Should
            election.Candidate.ElementAt(0).Votes.ShouldEqual(1);
            election.Candidate.ElementAt(0).Votes.ShouldNotBeSameAs(election.Candidate.ElementAt(1).Votes);


        }

        [Fact]
        public void Should_Retunr_names_of_repeat_Candidates()
        {
            //Given

            // criando candidatos
            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "922.736.560-50", 0);
            var candidateMaria = new Candidate("Maria", "573.225.920-18", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            // When

            var input = new List<string> { "Rodrigo" };
            var result = election.ReturnRepeatNames(input);
            var expected = new List<string> { "Rodrigo" };

            // Then
            Assert.Equal(expected, result);

        }


        [Fact]
        public void Should_return_Candidates_by_cpf()
        {
            // Dado / Setup

            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "926.647.960-89", 0);
            var candidateMaria = new Candidate("Maria", "573.225.920-18", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };
            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            //When
            var result = election.GetCandidateIdBycpf(candidateRodrigo.Cpf);
            // Deve / Asserções

            Assert.Equal(election.Candidate.ElementAt(0).Id, result);

        }

        public void Should_assertions()
        {
            // Dado / Setup

            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "240.634.220-46", 0);
            var candidateMaria = new Candidate("Maria", "486.869.430-80", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            var result = election.GetCandidateIdBycpf(candidateRodrigo.Cpf);
            // Should

            election.Candidate.ElementAt(0).ShouldBeType(typeof(Candidate));
            election.Candidate.ElementAt(0).Id.ShouldEqual(result);


            // object obj = null;
            // obj.ShouldBeNull();

            // obj = new object();

            // obj.ShouldNotBeNull();
            // obj.ShouldNotBeSameAs(new object());
            // obj.ShouldNotBeType(typeof(string));
            // obj.ShouldNotEqual("foo");

            // obj = "x";
            // obj.ShouldNotBeInRange("y", "z");
            // obj.ShouldBeInRange("a", "z");
            // obj.ShouldBeSameAs("x");

            // "This String".ShouldContain("This");
            // "This String".ShouldNotBeEmpty();
            // "This String".ShouldNotContain("foobar");

            // false.ShouldBeFalse();
            // true.ShouldBeTrue();

            // var list = new List<object>();
            // list.ShouldBeEmpty();
            // list.ShouldNotContain(new object());

            // var item = new object();
            // list.Add(item);
            // list.ShouldNotBeEmpty();
            // list.ShouldContain(item);
        }

        [Fact]
        public void Should_return_True_if_Candidates_are_Null()
        {
            // Dado / Setup

            var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "764.122.990-50", 0);
            var candidateMaria = new Candidate("Maria", "486.869.430-80", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };
            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            //When
            var result = election.GetCandidateIdBycpf(candidateRodrigo.Cpf);
            // Deve / Asserções
            election.Candidate.ElementAt(0).ShouldNotBeNull();

        }
        [Fact]
        public void Should_return_False_and_not_Vote_if_cpf_is_invalid()
        {
      var election = new Election();
            var candidateRodrigo = new Candidate("Rodrigo", "910.371.860-36", 0);
            var candidateMaria = new Candidate("Maria", "764.122.990-50", 0);

            var cantidatesList = new List<Candidate>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            var rodrigoId = election.GetCandidateIdByName("Rodrigo");
            var mariaId = election.GetCandidateIdByName("Maria");
            //To vote
            candidateRodrigo.Vote();
            candidateMaria.Vote();

            // Quando / Ação
            var winners = election.GetWinners();

            // Deve / Asserções

            Assert.Equal(election.Candidate.ElementAt(0).Id, winners[0].Id);
            Assert.Equal(election.Candidate.ElementAt(1).Id, winners[1].Id);
            Assert.Equal(election.Candidate.ElementAt(0).Votes, 1);

            //Should
            election.Candidate.ElementAt(0).Votes.ShouldEqual(1);
            election.Candidate.ElementAt(0).Votes.ShouldNotBeSameAs(election.Candidate.ElementAt(1).Votes);

        }

        [Fact]
        public void Should_return_false_and_not_vote_when_CPF_is_invalid()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78",0);
            var candidates = new List<Candidate>{Jose};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            // Quando / Ação
            var voteResult = election.Vote("1321");

            // Deve / Asserções
            var candidateJose = election.Candidate.First(x => x.Id == Jose.Id);
            Assert.Equal(0, candidateJose.Votes);
            Assert.False(voteResult);

            voteResult.ShouldEqual(false);
        

        }



    }
}


