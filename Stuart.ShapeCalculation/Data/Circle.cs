using SpencerStuart.ShapeCalculation.Enums;
using SpencerStuart.ShapeCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerStuart.ShapeCalculation.Data
{
    public class Circle : IShape
    {
        public Circle(int radius)
        {
            R = radius;
        }

        public int R { get; set; }

        public MoodTypes Mood { get; set; } = MoodTypes.Normal;

        public float GetArea()
        {
            return 3.1415f * (R * R);
        }

        public int GetCorners()
        {
            return 0;
        }

        public int GetMoodMultiplier()
        {
            return (int)Mood;
        }
    }
}
