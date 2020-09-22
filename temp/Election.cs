
using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    public class Election
    {
        //Creating the  first prop

        public List<(int id, string name)> Candidate { get; set; }

        public bool CreatedCandidates(List<(int id, string name)> candidate, string pass)
        {

            if ( pass == "CaDaStRaR")
            {
                Candidate = candidate.Select(item => {
                    return(item.id, item.name);
                }).ToList();
                return true;
            
            }
            return false;
        }   
       


    }


}