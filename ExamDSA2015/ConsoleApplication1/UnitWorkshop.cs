using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitsOfWork
{
    public class UnitWorkshop
    {
        HashSet<Unit> units;
        SortedSet<Unit> sortedUnits;
        Dictionary<string, SortedSet<Unit>> byType;
        
        public UnitWorkshop()
        {
              this.units = new HashSet<Unit>();
              this.sortedUnits = new SortedSet<Unit>();
              this.byType = new Dictionary<string, SortedSet<Unit>>();
        }

        public bool AddUnit(Unit unit)
        {
            if (this.units.Contains(unit))
            {
                return false;
            }

            if (!(this.byType.ContainsKey(unit.Type)))
            {
                this.byType[unit.Type] = new SortedSet<Unit>();
            }

            this.units.Add(unit);
            this.sortedUnits.Add(unit);
            this.byType[unit.Type].Add(unit);
            
            return true;
        }

        public bool RemoveUnit(Unit unitName)
        {
            Unit unitToDelete = new Unit();

            foreach (var item in units)
            {
                if (unitName.Name == item.Name)
                {
                    unitToDelete = item;
                    break;
                }
            }

            if (unitToDelete.Name != null)
            {
                units.Remove(unitToDelete);
                sortedUnits.Remove(unitToDelete);
                byType[unitToDelete.Type].Remove(unitToDelete);
                return true;
            }
            return false;
        }
        
        public IEnumerable<Unit> UnitsByType(string type)
        {
            if (!(byType.ContainsKey(type)))
            {
                return null;
            }
            return this.byType[type].Take(10);
        }

        public IEnumerable<Unit> PowerUnits(string type)
        {
            int n = int.Parse(type);
            
            return this.sortedUnits.Take(n);
        }
    }
}
