using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWTechnicalAssignment.Data
{
    public class DataBaseHelloWorldRepository : IHelloWorldRepository
    {
        public string GetMessage()
        {
            throw new NotImplementedException();
            //Get Informatoin from a database using entity framework, any other ORM or ADO.net
        }

        public bool SaveResponse( string reponse)
        {
            throw new NotImplementedException();
            //Save Informatoin to a database using entity framework, any other ORM or ADO.net
        }
    }
}
