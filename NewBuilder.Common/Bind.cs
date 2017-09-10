using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewBuilder.Common
{
    [Serializable]
    public class Bind : Base<Bind>
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public List<int> Keys { get; set; }

        public Bind()
        {
            Name = "";
            Count = 0;
            Keys = new List<int>();
        }

        public List<BindContent> GetBindContents()
        {
            List<BindContent> lbc = new List<BindContent>();
            foreach (BindContent bc in BindContent.Items)
                if (bc.BindId.Equals(Id))
                    lbc.Add(bc);
            return lbc;
        }

        public void SendMessage()
        {
            Thread t = new Thread(new ThreadStart(() =>
           {
               Keyboard kb = new Keyboard();
               int count = Count;

               lock (BindContent.Items)
                   if (count > 0)
                       foreach (BindContent bc in BindContent.Items)
                           if (bc.BindId.Equals(Id))
                           {
                               if (count-- <= 0)
                                   break;
                               if (bc.IsSend)
                               {
                                   kb.SendKeys("{F6}" + bc.Content + "{Enter}", true);
                                   Thread.Sleep(bc.Delay);
                               }
                               else
                               {
                                   kb.SendKeys("{F6}" + bc.Content, true);
                                   Thread.Sleep(bc.Delay);
                               }
                           }

           }));
            t.Start();
        }
    }
}
