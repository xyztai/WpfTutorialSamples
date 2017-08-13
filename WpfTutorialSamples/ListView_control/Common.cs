using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorialSamples.ListView_control
{
    public enum SexType { Male, Female };
    public class User2
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }

        public SexType Sex { get; set; }
    }
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public override string ToString()
        {
            return this.Name + ", " + this.Age + " years old";
        }
    }
}
