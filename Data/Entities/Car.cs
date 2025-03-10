using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Data.Entities;

public class Car : EntityBase
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Colour { get; set; }
    public int Year { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Type { get; set; }

    //Calculated property

    public int? NameLengh { get; set; }
    public decimal? TotalSales { get; set; }

    #region ToString Override
    public override string ToString()
    {
        StringBuilder sb = new(1024);

        sb.AppendLine($"{Make} ID:{Id}");
        sb.AppendLine($" Model: {Model}  Color: {Colour} Type: {Type ?? "n/a"}");
        sb.AppendLine($"Year: {Year}");
        sb.AppendLine($"Cost: {StandardCost:c} Price:{ListPrice:c}");
        if (NameLengh.HasValue)
        {
            sb.AppendLine($"   Name Length:  {NameLengh}");
        }
        if (TotalSales.HasValue)
        {
            sb.AppendLine($"   Total Sales: {TotalSales:c}");
        }
        return sb.ToString();
    }
    #endregion
}