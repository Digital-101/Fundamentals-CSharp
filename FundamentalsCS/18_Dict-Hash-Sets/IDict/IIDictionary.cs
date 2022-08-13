using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._18_Dict_Hash_Sets
{
    /// <summary>
    /// Interface that defines basic methods needed for a
    /// "dictionary" class which maps keys to values
    /// </summary>
    /// <typeparam name="K">Key type</typeparam>
    /// <typeparam name="V">Value type</typeparam>
    public interface IIDictionary<K, V>: IEnumerable<KeyValuePair<K, V>>
    {

        ///<summary>Finds the value mapped to the given key</summary>
        /// <param name="key">the key to be searched</param>
        /// <returns>value for the specified key if it presents,
        /// or null if there is no value with such key</returns>
        V Get(K key);

        /// <summary>Assigns the specified value to the specified key
        /// in the dictionary. If the key already exists, its value is
        /// replaced with the new value and the old value is returned
        /// </summary>
        /// <param name="key">Key for the new value</param>
        /// <param name="value">Value to be mapped to that key</param>
        /// <returns>the old (replaced) value for the specified key
        /// or null if the key does not exist</returns>
        V Set(K key, V value);

        /// <summary>Assigns the specified value to the specified key
        /// in the dictionary. If the key already exists, its value is
        /// replaced with the new value and the old value is returned
        /// </summary>
        /// <param name="key">Key for the new value</param>
        /// <param name="value">Value to be mapped to that key</param>
        /// <returns>the old (replaced) value for the specified key
        /// or null if the key does not exist</returns>
        V this[K key] { get;set; }

        /// <summary>Removes an element in the dictionary identified
        /// by a specified key</summary>
        /// <param name="key">the key identifying the element to be
        /// removed</param>
        /// <returns>whether the element was removed or not</returns>
        bool Remove(K key);

        /// <summary>Returns the number of entries in the dictionary
        /// </summary>
        int Count { get; }

        /// <summary>Removes all the elements from the dictionary
        /// </summary>
        void Clear();
    }
}
