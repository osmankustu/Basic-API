using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succes, string massage):this(succes)
        {
            Massage = massage;
        }
        
        public Result(bool succes) 
        {
            Succes = succes;
        }

        public bool Succes { get; }

        public string Massage { get; }
    }
}
