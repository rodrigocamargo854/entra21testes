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
            var candidates = new List<(string name, string cpf, int votes)> { ("José", "8929831321", 0) };

            // Then // acessa o metodo CreateCandidates por meio do selection, com os dados e o pass
            var created = election.CreateCandidates(candidates, "incorrect");

            // When // assegura-se que não criou nenhum candidato
            Assert.Null(election.Candidates);
            Assert.False(created);


        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            //Given
            var election = new Election();
            (string candidateName, string cpf, int votes) candidate1 = ("José", "9078790", 0);
            (string candidateName, string cpf, int votes) candidate2 = ("Rodrigo", "93422", 0);

            var candidates = new List<(string name, string cpf, int votes)> { (candidate1), (candidate2) };

            // When //acessa o metodo CreateCandidates por meio do selection, com os dados e o pass
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Then // candidatos devem ser criados
            Assert.True(created);

            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.True(election.Candidates.Count == 2);
            //assegura que a pos 0 nome e igual ao nome do candidato 1
            Assert.True(election.Candidates[0].name == candidate1.candidateName);
            //assegura q a pos 1 do noome e igual ao nome do candidato2
            Assert.True(election.Candidates[1].name == candidate2.candidateName);
            //asegura que os nomes são diferentes
            Assert.True(election.Candidates[1].name != election.Candidates[0].name);
            //assegura que os candidatos não possuem votos
            Assert.True(election.Candidates[1].votes == 0);
            Assert.True(election.Candidates[0].votes == 0);
            //assegura que os ids são diferentes
            Assert.True(election.Candidates[1].id != election.Candidates[0].id);
            Assert.True(election.Candidates[1].id != election.Candidates[0].id);


        }


        [Fact]
        public void should_return_different_ids()
        {
            // Given
            var election = new Election();// cria-se objeto do tipo Election
            //Cria-se tuplas com dandidatos
            (string jose, string cpfJose, int votes) joseCand = ("Jose", "342342543", 0);
            (string adilson, string cpfAdilson, int votes) candAdil = ("adilson", "342342543", 0);

            //When
            //dentro de candidates cria-se uma lista de tuplas para os candidatos
            var candidates = new List<(string name, string cpf, int votes)> { (joseCand), (candAdil) };
            election.CreateCandidates(candidates, "Pa$$w0rd"); // cria-se candidatos

            //joseId recebe o retorno do metodo GetCandidateIdByName por meio do election
            var joseId = election.GetCandidateIdByName(joseCand.jose, joseCand.cpfJose, joseCand.votes);
            var adilsonId = election.GetCandidateIdByName(candAdil.adilson, candAdil.cpfAdilson, candAdil.votes);

            //Then
            //Assegura-se que os ids de ambos os candidatos sejam diferentes
            Assert.True(joseId != adilsonId);
            



        }
        [Fact]
        public void should_vote_twice_in_candidate_Jose()
        {
            //Given
            var election = new Election();

            (string jose, string cpfJose, int votes) joseCand = ("Jose", "342342543", 0);
            (string adilson, string cpfAdilson, int votes) candAdil = ("adilson", "342342543", 0);
            var candidates = new List<(string name, string cpf, int votes)> { (joseCand), (candAdil) };
            election.CreateCandidates(candidates, "Pa$$w0rd");

            var joseId = election.GetCandidateIdByName(joseCand.jose, joseCand.cpfJose, joseCand.votes);
            var adilsonId = election.GetCandidateIdByName(candAdil.adilson, candAdil.cpfAdilson, candAdil.votes);

            //when
            election.Vote(election.Candidates[0].id);
            election.Vote(election.Candidates[0].id);

            //Then
            Assert.Equal(2, election.Candidates[0].votes);
            Assert.Equal(0, election.Candidates[1].votes);

        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Jose_receives_votes()
        {
            var election = new Election();

            (string jose, string cpfJose, int votes) joseCand = ("Jose", "342342543", 0);
            (string adilson, string cpfAdilson, int votes) candAdil = ("adilson", "342342543", 0);
            var candidates = new List<(string name, string cpf, int votes)> { (joseCand), (candAdil) };
            election.CreateCandidates(candidates, "Pa$$w0rd");


            var joseId = election.GetCandidateIdByName(joseCand.jose, joseCand.cpfJose, joseCand.votes);

            // Given
            election.Vote(election.Candidates[0].id);
            election.Vote(election.Candidates[0].id);
            // When

            var winners = election.GetWinners();

            //Then
            Assert.True(winners.Count == 1);
            Assert.Equal(election.Candidates[0].id, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();

            (string jose, string cpfJose, int votes) joseCand = ("Jose", "342342543", 0);
            (string adilson, string cpfAdilson, int votes) candAdil = ("adilson", "342342543", 0);
            var candidates = new List<(string name, string cpf, int votes)> { (joseCand), (candAdil) };
            election.CreateCandidates(candidates, "Pa$$w0rd");

            var joseId = election.GetCandidateIdByName(joseCand.jose, joseCand.cpfJose, joseCand.votes);
            var adilsonId = election.GetCandidateIdByName(candAdil.adilson, candAdil.cpfAdilson, candAdil.votes);

            election.Vote(joseId);
            election.Vote(adilsonId);



            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(joseId);
            election.Vote(adilsonId);
            var winners = election.GetWinners();

            // Deve / Asserções
        }

        [Fact]
        public void Should_Retunr_names_of_repeat_Candidates()
        {
            //Given

            // OBJETO election /// criando candidatos
            var election = new Election();
            (string candidateName, string cpf, int votes) candidate1 = ("José", "9078790", 0);
            (string candidateName, string cpf, int votes) candidate2 = ("maria", "9343422", 0);
            var candidates = new List<(string name, string cpf, int votes)> { (candidate1), (candidate2) };
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // When

            var input = new List<string> { "José" };
            var result = election.ReturnRepeatNames(input);
            var expected = new List<string> { "José" };

            // Then
            Assert.Equal(expected, result);

        }


        [Fact]
        public void Should_return_Candidates_by_cpf()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            (string candidateName, string cpf, int votes) candidate1 = ("José", "9078790", 0);

            var candidates = new List<(string name, string cpf, int votes)> { (candidate1) };

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            var result = election.GetCandidateIdBycpf(candidate1.cpf);
            // Deve / Asserções

            Assert.Equal(election.Candidates[0].id, result);

        }




    }
}


