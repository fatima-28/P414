using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Utility.Exceptions
{
  public  class IndexOutOfBoundsException:Exception
    {
        public IndexOutOfBoundsException(string message):base(message)
        {

        }
    }
}
