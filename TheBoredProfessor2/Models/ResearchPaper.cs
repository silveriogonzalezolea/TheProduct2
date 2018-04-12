using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBoredProfessor2.Models
{
    public class ResearchPaper
    {
        public string Keywords { get; set; }
        public string Absract { get; set; }
        public int ResearchPaperId { get; set; }
        private static int nextId = 1;

        public ResearchPaper()
        {
            ResearchPaperId = nextId;
            nextId++;

        }
    }
}
