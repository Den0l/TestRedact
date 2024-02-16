using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    internal class ClassMark
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public DateTime DateMark { get; set; }

        public ClassMark(string Name, string Mark, DateTime DateMark)
        {
            this.Name = Name;
            this.Mark = Mark;
            this.DateMark = Convert.ToDateTime(DateMark.ToShortDateString());
        }

    }
}
