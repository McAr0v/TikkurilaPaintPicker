using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikkurilaPaintPicker.Paint.Enums;

namespace TikkurilaPaintPicker.Paint
{
    public class PaintClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Consumption { get; set; }
        public List<PaintMaterialEnum> Materials { get; set; }
        public List<PaintObjectEnum> Objects { get; set; }
        public List<PaintLocationEnum> Locations { get; set; }
        public PaintThinnerEnum Thinner { get; set; }
        public List<PaintColorEnum> Colors {  get; set; }
        public List<PaintGlossEnum> Gloss { get; set; }
        public List<CategoryEnums> Categories { get; set; }


    }
}
