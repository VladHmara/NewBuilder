using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBuilder.Common;

namespace Builder.Interface
{
    public class BindContentTemp
    {
        public BindContent myBindContent { get; set; }
        public string ContentTemp { get; set; }
        public string DelayTemp { get; set; }
        public bool IsSendTemp { get; set; }

        public BindContentTemp(BindContent bindContent)
        {
            myBindContent = bindContent;
            ContentTemp = myBindContent.Content;
            DelayTemp = myBindContent.Delay.TotalMilliseconds.ToString();
            IsSendTemp = myBindContent.IsSend;
        }

        public void SaveChange()
        {
            myBindContent.Content = ContentTemp;
            myBindContent.Delay = new TimeSpan(0, 0, 0, 0, Int32.Parse(DelayTemp));
            myBindContent.IsSend = IsSendTemp;
        }
    }
}
