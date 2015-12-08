using System;

namespace UnitsOfWork
{
    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Attack { get; set; }

        public Unit()
        {

        }
        public Unit(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Unit;
            if (other == null)
            {
                return false;
            }

            return this.Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return 23 + this.Name.GetHashCode() >> 17 ^
                   (23 + this.Attack.GetHashCode() >> 17 ^
                    (23 + this.Type.GetHashCode() >> 17));
        }

        public int CompareTo(Unit other)
        {
            var priceCompareResult = this.Attack.CompareTo(other.Attack);
            if (priceCompareResult == 0)
            {
                var namesCompareResult = this.Name.CompareTo(other.Name);
                return namesCompareResult;
            }
            else
            {
                return priceCompareResult * -1;
            }
        }

        public static Unit ParseUnit(string unitString)
        {
            string[] parts = unitString.Split(' ');
            var name = parts[0];
            var type = parts[1];
            var attack = int.Parse(parts[2]);

            return new Unit()
            {
                Name = name,
                Attack = attack,
                Type = type
            };
        }
    }
}