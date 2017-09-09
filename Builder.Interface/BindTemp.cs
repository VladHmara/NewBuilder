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
        public Bind MyBind { get; set; }
        public string KeysTemp { get; set; }
        public string NameTemp { get; set; }
        public int CountTemp { get; set; }
        
        public BindTemp(Bind bind)
        {
            MyBind = bind;
            NameTemp = MyBind.Name;
            CountTemp = MyBind.Count;
            KeysTemp = KeysCode.ListToString(MyBind.Keys);
        }

        public void SaveChange()
        {
            MyBind.Name = NameTemp;
            MyBind.Count = CountTemp;
            MyBind.Keys = KeysCode.StringToList(KeysTemp);
        }
    }
}
