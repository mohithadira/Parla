using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveryGuru.Entity
{
    public class DataEntryException4 : Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid ward!! Ward should only be North | South | East | West";
            }
        }
    }
}
