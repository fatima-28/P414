using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
  public  class ShopCenter:BaseEntity
    {
        public Liberary[] liberaries;
        public ShopCenter( int size)
        {

            liberaries = new Liberary[size];

        }
        public Liberary this[int index]
        {
            get
            {
                if (index < liberaries.Length && liberaries[index] != null)
                {
                    return liberaries[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < liberaries.Length)
                {
                    liberaries[index] = value;
                }

            }
        }
     }
}
