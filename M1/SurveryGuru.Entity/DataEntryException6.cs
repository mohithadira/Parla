using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataEntryException6 : Exception
    {
        public override string Message
        {
            get
            {
                return "Reasons to vote should be less than 200 characters";
            }
        }
    }
}
