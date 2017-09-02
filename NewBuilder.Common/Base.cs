using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewBuilder.Common
{
    public class Base<T>
        where T : Base<T>
    {

    }
}
