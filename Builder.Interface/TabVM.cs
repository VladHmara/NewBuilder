using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBuilder.Common;

namespace Builder.Interface
{
    public class TabVM
    {
        public List<BindVM> Items { get; set; }
        public TabVM()
        {
            Items = new List<BindVM>();
            for(int i = 0; i < 10; i++)
                Items.Add(new BindVM(i));
        }
        public void SaveChange()
        {
            foreach (BindVM bv in Items)
                bv.SaveChange();
        }
    }
}
