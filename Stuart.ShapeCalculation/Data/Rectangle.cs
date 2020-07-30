using SpencerStuart.ShapeCalculation.Enums;
using SpencerStuart.ShapeCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpencerStuart.ShapeCalculation.Data
{
    public class Rectangle : IShape
    {
        public Rectangle(int sideA, int sideB)
        {
            A = sideA;
            B = sideB;
        }

        public int A { get; set; }

        public int B { get; set; }

        public MoodTypes Mood { get; set; } = MoodTypes.Normal;

        public float GetArea()
        {
            return A * B;
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
