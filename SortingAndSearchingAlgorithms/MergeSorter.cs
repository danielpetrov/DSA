namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            var newCollection = MergeSort(collection).ToList();
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = newCollection[i];
            }
        }

        private IList<T> MergeSort(IList<T> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            var left = new List<T>();
            var right = new List<T>();

            int listCount = list.Count;
            int middle = listCount / 2;

            for (int i = 0; i < listCount; i++)
            {
                if (i < middle)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            left = MergeSort(left).ToList();
            right = MergeSort(right).ToList();

            return Merge(left, right);
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            var result = new List<T>();
            var first = 0;
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[first].CompareTo(right[first]) <= 0)
                {
                    result.Add(left[first]);
                    left.RemoveAt(first);
                }
                else
                {
                    result.Add(right[first]);
                    right.RemoveAt(first);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[first]);
                left.RemoveAt(first);
            }

            while (right.Count > 0)
            {
                result.Add(right[first]);
                right.RemoveAt(first);
            }

            return result;

        }
    }
}
