using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewBuilder.Common
{
    [Serializable]
    public class Bind : Base<Bind>
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int ModKey { get; set; }
        public int Key { get; set; }
    }
}
