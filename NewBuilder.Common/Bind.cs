using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //    Thread t = new Thread(new ThreadStart(() =>
            //   {
            int count = Count;
            //lock (BindContent.Items)
            if (count > 0)
                foreach (BindContent bc in BindContent.Items)
                    if (bc.BindId.Equals(Id))
                    {
                        if (count-- <= 0)
                            break;
                        if (bc.IsSend)
                        {
                            Keyboard kb = new Keyboard();
                            kb.SendKeys(bc.Content + "{Enter}", true);
                            Thread.Sleep(bc.Delay);
                        }
                        else
                        {
                            object bufer = Clipboard.GetDataObject(); // сохраняем данные из буфера
                            Clipboard.SetText(bc.Content);
                            SendKeys.SendWait("^v");
                            Clipboard.SetDataObject(bufer); // возвращаем первоначальные данные в буфер
                            // дописать {F6}
                            Thread.Sleep(bc.Delay);
                        }
                    }

            //}));
            // t.Start();
        }
    }
}
