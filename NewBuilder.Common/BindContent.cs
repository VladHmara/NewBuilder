using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBuilder.Common
{
    [Serializable]
    public class BindContent : Base<BindContent>
    {
        public Guid BindId { get; }
        public string Content { get; set; }
        public TimeSpan Delay { get; set; }
        public bool IsSend { get; set; }

        public BindContent(Guid bindId)
        {
            BindId = bindId;
            Content = "";
            Delay = TimeSpan.Zero;
            IsSend = false;
        }
    }
}
