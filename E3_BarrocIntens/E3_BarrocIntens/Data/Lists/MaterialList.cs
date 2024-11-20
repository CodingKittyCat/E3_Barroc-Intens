using E3_BarrocIntens.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_BarrocIntens.Data.Lists
{
    internal class MaterialList
    {

        List<Material> materialList = new List<Material>()
        {
            new Material(1, "Wooden Plank 50cm", "This plank is made from wood, I promise, no deceptions here."),
            new Material(2, "Wooden Plink 75cm", "This plank is made from wood, I promise, deceptions here."),
            new Material(3, "Wooden Plonk 25cm", "This plank is made from iron, I swear, no deceptions here."),
            new Material(4, "Wooden Plunk 20cm", "This 20cm is made from wood, I promise, deceptions here."),
        };

        public List<Material> GetMaterials()
        {
            return materialList;
        }
    }
}
