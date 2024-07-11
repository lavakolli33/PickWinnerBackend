using System.Collections.Generic;

namespace PickWinner.Helpers
{
    public static class RandomNumberHelper
    {
        public static Random randomizer = new Random();

        public static IEnumerable<T> GetRandomNumbersList<T>(IEnumerable<T> list, int numOfItems)
        {
            // Hashset to get a list of unique items
            var items = new HashSet<T>();
            // Add random numbers until you get the required number of items
            while (numOfItems > 0)
            {
                var index = randomizer.Next(list.Count());
                if (items.Add(list.ElementAt(index)))
                    numOfItems--;
            }
            return items;
        }

    }
}
