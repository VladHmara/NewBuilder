using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBuilder.Common;

namespace Builder.Interface
{
    public class BindContentVM
    {
        public List<BindContentTemp> Items { get; set; }
        public BindContentVM(Bind bind, int count)
        {
            Items = new List<BindContentTemp>();
            foreach (BindContent bc in BindContent.Items)
            {
                if (count <= 0)
                    break;
                if (bc.BindId.Equals(bind.Id))
                {
                    if (count-- <= 0)
                        break;
                    Items.Add(new BindContentTemp(bc));
                }
            }
            while(count-- > 0)
            {
                Items.Add(new BindContentTemp(new BindContent(bind.Id)));
            }
        }
        public void SaveChange()
        {
            foreach (BindContentTemp bc in Items)
                bc.SaveChange();
        }
    }
}
