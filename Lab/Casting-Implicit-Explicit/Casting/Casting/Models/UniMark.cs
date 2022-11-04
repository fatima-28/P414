using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    class UniMark
    {
        public int Midterm { get; set; }
        public UniMark(int midterm)
        {
            Midterm = midterm;
        }
        public static implicit operator SchoolMark(UniMark mark)
        {
            return new SchoolMark(mark.Midterm / 20);
        }
    }
}
