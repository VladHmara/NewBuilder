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
        public BindVM()
        {
            Items = new List<BindTemp>();
            foreach (Bind b in Bind.Items)
                Items.Add(new BindTemp(b));
        }
        public void SaveChange()
        {
            foreach (BindTemp bm in Items)
                bm.SaveChange();
        }
    }
}
