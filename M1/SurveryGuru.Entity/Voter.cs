using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    [Serializable]
    public class Voter
    {
        public string voterId { get; set; }
        public string voterName { get; set; }
        public string voterWard { get; set; }
        public string voterCity { get; set; }
        public string voterState { get; set; }
        public string voterParty { get; set; }
        public string voterReason { get; set; }

        public Voter()
        {
            voterState = "Karnataka";
        }
    }
}
