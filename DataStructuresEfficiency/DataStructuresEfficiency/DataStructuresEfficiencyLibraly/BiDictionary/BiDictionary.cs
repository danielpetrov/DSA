namespace DataStructuresEfficiencyLibraly.BiDictionary
{
    using System.Collections.Generic;
    public class BiDictionary<K1, K2, T> : SortedDictionary<K1, SortedDictionary<K2, List<T>>> { }
    
}
