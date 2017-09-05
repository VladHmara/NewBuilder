using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBuilder.Common;

namespace Builder.Interface
{
    public class BindModel
    {
        public Bind myBind { get; set; }
        public string NameTemp { get; set; }
        public int CountTemp { get; set; }
        public int ModKeyTemp { get; set; }
        public int KeyTemp { get; set; }

        public BindModel(Bind bind)
        {
            myBind = bind;
            NameTemp = myBind.Name;
            CountTemp = myBind.Count;
        }

        public void SaveChange()
        {
            myBind.Name = NameTemp;
            myBind.Count = CountTemp;
        }
    }
}
