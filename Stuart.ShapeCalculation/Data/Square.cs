using SpencerStuart.ShapeCalculation.Enums;
using SpencerStuart.ShapeCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerStuart.ShapeCalculation.Data
{
    public class Square : IShape
    {
        public Square(int side)
        {
            S = side;
        }

        public int S { get; set; }

        public MoodTypes Mood { get; set; } = MoodTypes.Normal;

        public float GetArea()
        {
            return S * S;
        }

        public int GetCorners()
        {
            return 4;
        }

        public int GetMoodMultiplier()
        {
            return (int)Mood;
        }
    }
}
