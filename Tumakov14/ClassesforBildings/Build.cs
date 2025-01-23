using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov14.ClassesforBildings;

namespace Tumakov14.ClassesforBank
{
    [DeveloperInfo("Иван Иванов", "Строительная Компания")]
    public class Build
{
    private Building[] buildings = new Building[10];

    public Building this[int index]
    {
        get
        {
            if (index < 0 || index >= buildings.Length)
                throw new IndexOutOfRangeException("Индекс вне диапазона!");
            return buildings[index];
        }
        set
        {
            if (index < 0 || index >= buildings.Length)
                throw new IndexOutOfRangeException("Индекс вне диапазона!");
            buildings[index] = value;
        }
    }
}

}
