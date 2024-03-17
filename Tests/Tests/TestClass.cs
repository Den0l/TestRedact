using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class TestClass
    {
        public string questionName { get; set; }
        public string questionDeskrp { get; set; }
        public string questionFirst { get; set; }
        public string questionSecond { get; set; }
        public string questionThird { get; set; }
        public string questionAnswer { get; set; }

        public TestClass(string questionName, string questionDeskrp, string questionFirst, string questionSecond, string questionThird, string questionAnswer) 
        { 
            this.questionName = questionName;
            this.questionDeskrp = questionDeskrp;
            this.questionFirst = questionFirst;
            this.questionSecond = questionSecond;
            this.questionThird = questionThird;
            this.questionAnswer = questionAnswer;
        }

    }

}
