using System;

namespace Task4_14;

public class ArmyParent
{
    public string Kind { get; set; } = "";
    public int Count { get; set; } = 0;
    public int Armament { get; set; } = 0;

    public ArmyParent(string kind, int count, int armament)
    {
        Kind = kind;
        Count = count;
        Armament = armament;
    }

    public ArmyParent()
    {
    }

    public float QFunction()
    {
        return 0.3F * Count + 0.7F * Armament;
    }

    public override string ToString()
    {
        return $"Армия: Вид войск - {Kind}, Численность - {Count} тыс. человек, Вооруженность - {Armament} баллов, Результат Q функции - {QFunction()}";
    }
}