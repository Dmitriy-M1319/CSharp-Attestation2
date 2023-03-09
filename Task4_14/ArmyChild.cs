using System;

namespace Task4_14;

public class ArmyChild : ArmyParent
{
   public int Experience { get; set; }

   public ArmyChild(string kind, int count, int armament, int exper) : base(kind, count, armament)
   {
      Experience = exper;
   }

   public new float QFunction()
   {
      return base.QFunction() * (Experience + 1);
   }

   public override string ToString()
   {
      return base.ToString() + $", Опыт - {Experience} месяцев";
   }
}