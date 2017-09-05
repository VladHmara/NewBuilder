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
        public List<BindModel> Items { get; set; }
        public BindVM()
        {
            Items = new List<BindModel>();
            foreach (Bind b in Bind.Items)
                Items.Add(new BindModel(b));
        }
        public void SaveChange()
        {
            foreach (BindModel bm in Items)
                bm.SaveChange();
        }
    }
}
