using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamesLib.Core
{
    /// <summary>A static class containing globally accessable methods to carry out curtain tasks.</summary>
    /// <typeparam name="T">The object type that will be used thoughout the algorithm.</typeparam>
    public static class Algorithms<T>
    {
        /// <summary>Shuffles the specified list.</summary>
        /// <param name="list">The list to be shuffled.</param>
        /// <returns>The list after being shuffled.</returns>
        public static List<T> Shuffle(List<T> list)
        {
            var rand = new Random();

            for (int idx = 0; idx < list.Count; ++idx)
            {
                var temp = list[idx];
                int randomIdx = rand.Next(list.Count);
                list[idx] = list[randomIdx];
                list[randomIdx] = temp;
            }

            return list;
        }
    }    
}
