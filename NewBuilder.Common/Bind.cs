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
        public string KeyStartChat { get; set; } //don't static cause serialization

        public Bind()
        {
            Name = "";
            Count = 1;
            Keys = new List<int>();
            KeyStartChat = "";
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

            //

            if (count > 0)
                foreach (BindContent bc in BindContent.Items)
                    if (bc.BindId.Equals(Id))
                    {
                        if (count-- <= 0)
                            break;
                        if (bc.IsSend)
                        {
                            Keyboard kb = new Keyboard();
                            string tempKey = "{" + KeyStartChat + "}";
                            kb.SendKeys(tempKey, true);
                            kb.SendKeys(bc.Content + "{Enter}", true);
                            Thread.Sleep(bc.Delay);
                        }
                        else
                        {
                            object bufer = Clipboard.GetDataObject(); // сохраняем данные из буфера
                            Clipboard.SetText(bc.Content);
                            SendKeys.SendWait("^v");
                            Clipboard.SetDataObject(bufer); // возвращаем первоначальные данные в буфер
                            // дописать {F6} + разобраться с сохранением в буфер и записью обратно
                            //Thread.Sleep(bc.Delay);
                        }
                    }
        }


        //}));
        // t.Start();
    }
}
