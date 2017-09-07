using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBuilder.Common;

namespace Builder.Interface
{
    public class BindTemp
    {
        public Bind myBind { get; set; }
        private string KeysTemp { get; set; }
        public string NameTemp { get; set; }
        public int CountTemp { get; set; }
        
        public BindTemp(Bind bind)
        {
            myBind = bind;
            NameTemp = myBind.Name;
            CountTemp = myBind.Count;
            KeysTemp = KeysCode.ListToString(myBind.Keys);
        }

        public void SaveChange()
        {
            myBind.Name = NameTemp;
            myBind.Count = CountTemp;
            //дописать 
        }
    }
}
