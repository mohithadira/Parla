using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataEntryException2 : Exception
    {
        public override string Message
        {
            get
            {
                return "VoterId must be 7 characters long, with first 2 characters uppercase letters followed by 5 didgits";
            }
        }
    }
}
