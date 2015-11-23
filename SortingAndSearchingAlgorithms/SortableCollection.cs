namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        private readonly Random rand = new Random();
        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.Items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var itemInList in this.items)
            {
                if (item.CompareTo(itemInList) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            return this.BinarySearch(item, 0, this.Items.Count);
        }
        

        private bool BinarySearch(T key, int imin, int imax)
        {
            if (imax < imin)
            {
                return false;
            }
            else
            {
                // calculate midpoint to cut set in half
                int imid = (imin + imax) / 2;
                
                // three-way comparison
                if (this.Items[imid].CompareTo(key) > 0)
                    // key is in lower subset
                    return BinarySearch(key, imin, imid - 1);
                else if (this.Items[imid].CompareTo(key) < 0)
                    // key is in upper subset
                    return BinarySearch(key, imid + 1, imax);
                else
                    // key has been found
                    return true;
            }
        }

        //from random import randrange
        //def sattoloCycle(items):
        //    i = len(items)
        //    while i > 1:
        //        i = i - 1
        //        j = randrange(i)  # 0 <= j <= i-1
        //        items[j], items[i] = items[i], items[j]
        //    return
        public void Shuffle()
        {
            int i = this.Items.Count;
            while ( i > 1 )
            {
                i--;
                int j = rand.Next(0, i);
                Swap(this.Items, i, j);
            }
        }

        private void Swap(IList<T> collection, int index1, int index2)
        {
            var swaper = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = swaper;
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.Items[i]);
                }
                else
                {
                    Console.Write(" " + this.Items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
