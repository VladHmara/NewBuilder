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
        public List<Bind> Items { get; set; }
        public BindVM()
        {
            Items = new List<Bind>();
            for (int i = 0; i < 10; i++)
                Items.Add(new Bind());
        }
    }
}
