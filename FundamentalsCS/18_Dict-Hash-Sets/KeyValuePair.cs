using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._18_Dict_Hash_Sets
{
    /// <summary>
    /// A structure holding a pair {key, value}
    /// </summary>
    /// <typeparam name="Tkey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public struct KeyValuePair<Tkey, TValue>
    {
        ///<summary>Holds the key of the key-value pair</summary>
        public Tkey Key { get; private set; }

        ///<summary>Holds the value of the key-value pair</summary>
        public TValue Value { get; private set; }

        ///<summary>Constructs a pair by given key + value</summary>
       public KeyValuePair(Tkey key, TValue value): this()
        {
            this.Key = key;
            this.Value = value;
        }
        /// <summary>Converts the key-value pair to a printable text.
        /// </summary>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('[');
            if (this.Key != null)
            {
                builder.Append(this.Key.ToString());
            }
            builder.Append(", ");
            if (this.Value != null)
            {
                builder.Append(this.Value.ToString());
            }
            builder.Append(']');
            return builder.ToString();
        }
    }
}
