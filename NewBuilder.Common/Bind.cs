using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
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

        //Дописать чтобы при дисериализации дописывало Hook
        //Дописать метод имитации клавиш
    }
}
