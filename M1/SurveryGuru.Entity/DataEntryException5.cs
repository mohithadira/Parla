using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataEntryException5 : Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid party!! Party should only be Congress | BJP | JD";
            }
        }
    }
}
