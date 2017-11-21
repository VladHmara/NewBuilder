using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBuilder.Common;

namespace Builder.Interface
{
    public class BindVM
    {
        public List<BindTemp> Items { get; set; }
        public BindVM(int page)
        {
            Items = new List<BindTemp>();
            for(int i = 0; i < 10; i++)
                Items.Add(new BindTemp(Bind.Items[page * 10 + i]));
        }
        public void SaveChange()
        {
            foreach (BindTemp bm in Items)
                bm.SaveChange();
        }
    }
}
