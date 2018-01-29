using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWTechnicalAssignment.Data
{
    public class FileHelloWorldRepository : IHelloWorldRepository
    {
        public string GetMessage()
        {
            throw new NotImplementedException();
            //When implementing this get information from a file
        }

        public bool SaveResponse(string response)
        {
            throw new NotImplementedException();
            //When implementing this save information to a file
        }
    }
}
