using SpencerStuart.ShapeCalculation.Data;
using SpencerStuart.ShapeCalculation.Enums;
using SpencerStuart.ShapeCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerStuart.ShapeCalculation
{
    public class ShapeCollection : List<IShape>
    {
        public float AreaSum()
        {
            return this.Sum(e => e.GetArea() * e.GetMoodMultiplier());
        }

        public int CornerSum()
        {
            return this.Sum(e => 
                e is Circle ?  
                e.GetMoodMultiplier() == (int)MoodTypes.Normal ? 0 : (e.GetMoodMultiplier() == (int)MoodTypes.Happy ? 5 : 10)
                : e.GetCorners() * e.GetMoodMultiplier());
        }
    }
}
