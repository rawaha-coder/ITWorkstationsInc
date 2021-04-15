using System;
using System.Collections.Generic;
using System.Text;

namespace ITWorkstationsInc.Model
{
    class CaseBox
    {
        private int caseId;
        private string caseName;
        private double casePrice;

        public int CaseId { get => caseId; set => caseId = value; }
        public string CaseName { get => caseName; set => caseName = value; }
        public double CasePrice { get => casePrice; set => casePrice = value; }
    }
}
