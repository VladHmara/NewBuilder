using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NewBuilder.Common
{
    [Serializable]
    abstract public class Base<T>
           where T : Base<T>
    {
        static List<T> _items = new List<T>();
        static public List<T> Items { get => _items; }
        public Guid Id { get; }
        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add((T)this);
        }
        static public T GetObjectById(Guid id)
        {
            foreach (T t in Items)
                if (t.Id.Equals(id))
                    return t;
            return null;
        }
        static public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(typeof(T).Name + ".dat", FileMode.Create))
            {
                formatter.Serialize(fs, Items);
            }
        }
        static public void Load()
        {
            if (File.Exists(typeof(T).Name + ".dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(typeof(T).Name + ".dat", FileMode.Open))
                {
                    _items = (List<T>)formatter.Deserialize(fs);
                }
            }
        }
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
