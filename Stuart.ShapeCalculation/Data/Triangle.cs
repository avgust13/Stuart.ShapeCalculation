using SpencerStuart.ShapeCalculation.Enums;
using SpencerStuart.ShapeCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerStuart.ShapeCalculation.Data
{
    public class Triangle : IShape
    {
        public Triangle(int sideB, int sideH)
        {
            B = sideB;
            H = sideH;
        }

        public int B { get; set; }

        public int H { get; set; }

        public MoodTypes Mood { get; set; } = MoodTypes.Normal;

        public float GetArea()
        {
            return (B * H) / 2;
        }

        public int GetCorners()
        {
            return 3;
        }

        public int GetMoodMultiplier()
        {
            return (int)Mood;
        }
    }
}
