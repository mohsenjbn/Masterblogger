using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain.Exeptions
{
    public class DoblicatedTitleExeption:Exception
    {
        public DoblicatedTitleExeption()
        {

        }

        public DoblicatedTitleExeption(string message):base(message)
        {
            

        }
    }
}
