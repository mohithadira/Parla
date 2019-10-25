using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataEntryException1 : Exception
    {
        public override string Message
        {
            get
            {
                return "All Fields are Mandatory";
            }
        }
    }
}
