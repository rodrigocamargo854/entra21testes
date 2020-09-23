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
            // Dado / Setup
            var election = new Election();
            var candidates = new List<(string name, string cpf)> { ("José", "8929831321") };

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
            (string candidateName, string cpf) candidate = ("José", "9078790");
            var candidates = new List<(string name, string cpf)> { (candidate) };

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);

            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.True(election.Candidates.Count == 1);
            Assert.True(election.Candidates[0].name == candidate.candidateName);
        }


            [Fact]
        public void should_return_different_ids()
        {
            var election = new Election();
            (string jose,string cpfJose) = ("Jose","342342543");
            (string adilson,string cpfAdilson) = ("adilson","342342543");

            var candidates = new List<(string name, string cpf)> {(jose, adilson)};
            election.CreateCandidates(candidates, "Pa$$w0rd");

            var joseId = election.GetCandidateIdByName(jose,cpfJose);
            var adilsonId = election.GetCandidateIdByName(adilson,cpfAdilson);

            Assert.True(joseId != adilsonId);
        }
        //     [Fact]
        //     public void should_vote_twice_in_candidate_Fernando()
        //     {
        //         // Dado / Setup
        //         // OBJETO election
        //         var election = new Election();
        //         (string name, string cpf) fernando = ("fernando", "34252523");
        //         (string name, string cpf) adilson = ("adilson", "4242343");
        //         var candidate1 = new List<(string name, string cpf)> { (fernando) };
        //         var candidate2 = new List<(string name, string cpf)> { (adilson) };


        //         election.CreateCandidates(candidate1, "Pa$$w0rd");
        //         var fernandoId = election.GetCandidateIdByName(fernando);
        //         var adilsonId = election.GetCandidateIdByName(adilson);

        //         // Quando / Ação
        //         // Estamos acessando o MÉTODO ShowMenu do OBJETO election
        //         election.Vote(fernandoId);
        //         election.Vote(fernandoId);

        //         // Deve / Asserções
        //         var candidateFernando = election.Candidates.Find(x => x.id == fernandoId);
        //         var candidateAdilson = election.Candidates.Find(x => x.id == adilsonId);
        //         Assert.Equal(2, candidateFernando.votes);
        //         Assert.Equal(0, candidateAna.votes);
        //     }

        //     [Fact]
        //     public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        //     {
        //         // Dado / Setup
        //         // OBJETO election
        //         var election = new Election();
        //         (string name, string cpf) CandidateJose = ("José", "9679869867");
        //         (string name, string cpf) CandidateAna = ("Ana", "43534554");
        //         var candidates = new List<(string name, string cpf)> { (CandidateJose), (CandidateAna) };
        //         election.CreateCandidates(candidates, "Pa$$w0rd");

        //         var anaId = election.GetCandidateIdByName(ana);

        //         // Quando / Ação
        //         // Estamos acessando o MÉTODO ShowMenu do OBJETO election
        //         election.Vote(anaId);
        //         election.Vote(anaId);
        //         var winners = election.GetWinners();

        //         // Deve / Asserções
        //         Assert.True(winners.Count == 1);
        //         Assert.Equal(anaId, winners[0].id);
        //         Assert.Equal(2, winners[0].votes);
        //     }

        //     [Fact]
        //     public void should_return_both_candidates_when_occurs_draw()
        //     {
        //         // Dado / Setup
        //         // OBJETO election
        //         var election = new Election();
        //         string fernando = "Fernando";
        //         string ana = "Ana";
        //         var candidates = new List<string> { fernando, ana };
        //         election.CreateCandidates(candidates, "Pa$$w0rd");
        //         var fernandoId = election.GetCandidateIdByName(fernando);
        //         var anaId = election.GetCandidateIdByName(ana);

        //         // Quando / Ação
        //         // Estamos acessando o MÉTODO ShowMenu do OBJETO election
        //         election.Vote(anaId);
        //         election.Vote(fernandoId);
        //         var winners = election.GetWinners();

        //         // Deve / Asserções
        //         var candidateFernando = winners.Find(x => x.id == fernandoId);
        //         var candidateAna = winners.Find(x => x.id == anaId);
        //         Assert.Equal(1, candidateFernando.votes);
        //         Assert.Equal(1, candidateAna.votes);
        //     }
        // }
    }
}

