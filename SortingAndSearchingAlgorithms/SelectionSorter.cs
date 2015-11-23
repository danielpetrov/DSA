namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int collectionCount = collection.Count;

            for (int i = 0; i < collectionCount; i++)
            {
                int min = i;

                for (int j = i + 1; j < collectionCount; j++)
                {
                    if (collection[min].CompareTo(collection[j]) > 0)
                    {
                        min = j;
                    }
                }

                Swap(collection, i, min);
            }
        }

        private void Swap(IList<T> collection, int index1, int index2)
        {
            var swaper = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = swaper;
        }
    }
}
