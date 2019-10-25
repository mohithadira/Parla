using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataEntryException3 : Exception
    {
        public override string Message
        {
            get
            {
                return "Voter name should be between 4 to 8 characters long";
            }
        }
    }
}
