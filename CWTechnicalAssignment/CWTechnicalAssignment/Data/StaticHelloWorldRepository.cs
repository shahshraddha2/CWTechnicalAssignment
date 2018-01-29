using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWTechnicalAssignment.Data
{
    public class StaticHelloWorldRepository : IHelloWorldRepository
    {
        public string GetMessage()
        {
            return "Hello World";
        }

        public bool SaveResponse(string response)
        {
            if (response == null || response.Length == 0)
                return false;
            //Assume we got Informatoin
            return true;
        }
    }
}
