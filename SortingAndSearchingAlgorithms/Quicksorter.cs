namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {

        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
            
        }

        private void QuickSort(IList<T> collection, int low, int high)
        {
            if (low < high)
            {
                var p = Partition(collection, low, high);
                QuickSort(collection, low, p - 1);
                QuickSort(collection, p + 1, high);
            }
        }

        private int Partition(IList<T> array, int low, int high)
        {
            var pivot = array[high];
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (pivot.CompareTo(array[j]) >= 0)
                {
                    Swap(array, i++, j);
                }
            }

            Swap(array, i, high);

            return i;
        }

        private void Swap(IList<T> collection, int index1, int index2)
        {
            var swaper = collection[index1];
            collection[index1] = collection[index2];
            collection[index2] = swaper;
        }
    }
}
