using System;
using System.Collections.Generic;
using System.Text;

namespace TestProvaQuestao7 {
    public class Questao7Prova {
        public double Questao7 (int[] digitCodes) 
        {   
            var bornSc = 0.0;

            (int codes , string states) codeSc = (42,"SC");
            //tuplas para ufs dos estados
            var UFs = new (int id, string UF)[27]
            {
                codeSc,
                (11, "RO"),
                (12, "AC"),
                (13, "AM"),
                (14, "RR"),
                (15, "PA"),
                (16, "AP"),
                (17, "TO"),
                (21, "MA"),
                (22, "PI"),
                (23, "CE"),
                (24, "RN"),
                (25, "PB"),
                (26, "PE"),
                (27, "AL"),
                (28, "SE"),
                (29, "BA"),
                (31, "MG"),
                (32, "ES"),
                (33, "RJ"),
                (35, "SP"),
                (41, "PR"),
                (43, "RS"),
                (50, "MS"),
                (51, "MT"),
                (52, "GO"),
                (53, "DF")
            };

            for (int i = 0; i < digitCodes.Length; i++)

            {
                if (digitCodes[i] == codeSc.codes)
                {
                    bornSc ++;
                }             

            }

            return Math.Round((bornSc * 100) / digitCodes.Length, 2);
        }
    }
}
