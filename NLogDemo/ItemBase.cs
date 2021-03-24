using System;

namespace NLogDemo
{
    public class ItemBase:IComparable<ItemBase>
    {

        public int Id { get; set; }

        public int CompareTo(ItemBase other)
        {
          return  this.Id.CompareTo(other.Id);
        }

        public override bool Equals(object obj)
        {
            return obj is ItemBase @base &&
                   Id == @base.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}}}";
        }
    }
}