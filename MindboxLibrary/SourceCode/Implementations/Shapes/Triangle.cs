﻿using MindboxLibrary.SourceCode.Interfaces.Shapes;
using MindboxLibrary.SourceCode.Interfaces.Calculators;
using MindboxLibrary.SourceCode.Implementations.Calculators;

namespace MindboxLibrary.SourceCode.Implementations.Shapes
{
    public class Triangle : IShape
    {
        public IAreaCalculator AreaCalculator { get; }

        public IAngleChecker AngleChecker { get; }

        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public double Area { get; }

        public bool IsRightAngle { get; }

        public Triangle(double a, double b, double c)
        {
            AreaCalculator = new TriangleAreaCalculator(a, b, c);
            AngleChecker = new RightAngleChecker(a, b, c);
            SideA = a;
            SideB = b;
            SideC = c;
            Area = AreaCalculator.CalculateArea();
            IsRightAngle = AngleChecker.CheckAngle();
        }

        private Triangle()
        : this(0, 0, 0) { }
    }
}
