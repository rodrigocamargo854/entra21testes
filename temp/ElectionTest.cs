using System;
using Xunit;
using System.Collections.Generic;

namespace temp
{
    public class ElectionTest
    {


        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            //Given
            var election = new Election();// cria-se obejto Election
            // candidates armazena os dados do candidato que deseja-se criar

            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateRodrigo, candidateMaria
            };


            // Then // acessa o metodo CreateCandidates por meio do selection, com os dados e o pass
            var created = election.CreateCandidates(cantidatesList, "incorrect");

            // When // assegura-se que não criou nenhum candidato
            Assert.Null(election.Candidates);
            Assert.False(created);
           


        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            //Given
            var election = new Election();
            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateRodrigo, candidateMaria
            };



            // When //acessa o metodo CreateCandidates por meio do selection, com os dados e o pass
            var created = election.CreateCandidates(cantidatesList, "Pa$$w0rd");

            // Then // candidatos devem ser criados
            Assert.True(created);

            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.True(cantidatesList.Count == 2);
            //assegura que a pos 0 nome e igual ao nome do candidato 1
            Assert.True(cantidatesList[0].Name == candidateRodrigo.Name);
            //assegura q a pos 1 do noome e igual ao nome do candidato2
            Assert.True(cantidatesList[1].Name == candidateMaria.Name);
            //asegura que os nomes são diferentes
            Assert.True(cantidatesList[1].Name != cantidatesList[0].Name);
            //assegura que os candidatos não possuem votos
            Assert.True(cantidatesList[1].Votes == 0);
            Assert.True(cantidatesList[0].Votes == 0);
            //assegura que os ids são diferentes
            Assert.True(cantidatesList[1].Id != cantidatesList[0].Id);
            Assert.True(cantidatesList[1].Id != cantidatesList[0].Id);


        }

        [Fact]
        public void should_return_different_ids()
        {
            //Given
            var election = new Election();
            var candidateJose = new Candidates("José", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateJose, candidateMaria
            };

            //When

            var candidates = election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos
            
            //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var joseId = election.GetCandidateIdByName("José");
            var mariaId = election.GetCandidateIdByName( "Maria");

            //Then
            Assert.NotEqual(joseId,mariaId);

             




        }
        [Fact]
        public void should_vote_twice_in_candidate_Jose()
        {

            //Given
            var election = new Election();
            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos
                                                                   //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var rodrigoId = election.GetCandidateIdByName("Rodrigo");
            var mariaId = election.GetCandidateIdByName("Maria");

            //when
            election.Vote(cantidatesList[0].Id);
            election.Vote(cantidatesList[0].Id);

            //Then
            Assert.Equal(2, cantidatesList[0].Votes);
            Assert.Equal(0, cantidatesList[1].Votes);

        }

        [Fact]
        public void should_return_Rodrigo_as_winner_when_only_Rodrigo_receives_votes()
        {
            //Given
            var election = new Election();
            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos
                                                                   //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var rodrigoId = election.GetCandidateIdByName( "Rodrigo");
            var mariaId = election.GetCandidateIdByName( "Maria");

            // Given
            election.Vote(cantidatesList[0].Id);
            election.Vote(cantidatesList[0].Id);
            // When

            var winners = election.GetWinners();

            //Then
            Assert.True(winners.Count == 1);
            Assert.Equal(cantidatesList[0].Id, winners[0].Id);
            Assert.Equal(2, winners[0].Votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            var election = new Election();
            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            var rodrigoId = election.GetCandidateIdByName("Rodrigo");
            var mariaId = election.GetCandidateIdByName("Maria");
            //To vote
            election.Vote(rodrigoId);
            election.Vote(mariaId);

            // Quando / Ação
            var winners = election.GetWinners();

            // Deve / Asserções
        }

        [Fact]
        public void Should_Retunr_names_of_repeat_Candidates()
        {
            //Given

            // criando candidatos
            var election = new Election();
            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
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
            var candidateRodrigo = new Candidates("Rodrigo", "000.123.452-00", 0);
            var candidateMaria = new Candidates("Maria", "112.342.543-88", 0);

            var cantidatesList = new List<Candidates>()
            {
                candidateRodrigo, candidateMaria
            };

            //When

            election.CreateCandidates(cantidatesList, "Pa$$w0rd"); // cria-se candidatos

            var result = election.GetCandidateIdBycpf(candidateRodrigo.Cpf);
            // Deve / Asserções

            Assert.Equal(cantidatesList[0].Id, result);

        }




    }
}


