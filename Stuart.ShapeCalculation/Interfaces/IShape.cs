using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerStuart.ShapeCalculation.Interfaces
{
    public interface IShape
    {
        float GetArea();
        int GetCorners();
        int GetMoodMultiplier();
    }
}
