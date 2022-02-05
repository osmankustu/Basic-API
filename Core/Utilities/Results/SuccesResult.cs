using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccesResult : Result
    {
        public SuccesResult(string massage) : base(true, massage)
        {

        }
        
        public SuccesResult() : base(true)
        {

        }
    }
}
