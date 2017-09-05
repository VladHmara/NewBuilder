using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBuilder.Common
{
    [Serializable]
    class BindContent : Base<BindContent>
    {
        string Content { get; set; }
        Guid BindId { get; }
        TimeSpan Delay { get; set; }
        bool IsSend { get; set; }
    }
}
