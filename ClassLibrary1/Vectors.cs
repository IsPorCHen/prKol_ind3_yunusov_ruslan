using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vectors
    {
        private double[] _vector = new double[3];

        public Vectors() { }

        public Vectors(double x, double y, double z)
        {
            _vector[0] = x;
            _vector[1] = y;
            _vector[2] = z;
        }

        public double[] GetCoordinates
        {
            get { return _vector; }
            set { _vector = value; }
        }

        public Vectors ArithmeticOperationsOnVectors(bool isAddition, Vectors firstVector, Vectors secondVector)
        {
            Vectors thirdVector;

            double[] _newVector = new double[3];
            int sign = isAddition ? 1 : -1;

            _newVector[0] = firstVector._vector[0] + (secondVector._vector[0] * sign);
            _newVector[1] = firstVector._vector[1] + (secondVector._vector[1] * sign);
            _newVector[2] = firstVector._vector[2] + (secondVector._vector[2] * sign);

            thirdVector = new Vectors(_newVector[0], _newVector[1], _newVector[2]);

            return thirdVector;
        }

        public double DotProduct(Vectors secondVector)
        {
            return Math.Round(_vector[0] * secondVector._vector[0] + _vector[1] * secondVector._vector[1] 
                + _vector[2] * secondVector._vector[2], 2);
        }

        public double Magnitude()
        {
            return Math.Round(Math.Sqrt(Math.Pow(_vector[0], 2) + Math.Pow(_vector[1], 2) + Math.Pow(_vector[2], 2)), 2);
        }

        public double CosineAngle(Vectors secondVector)
        {
            double dotProduct = DotProduct(secondVector);
            double magnitudeProduct = Magnitude() * secondVector.Magnitude();

            if (magnitudeProduct == 0)
            {
                throw new InvalidOperationException("error");
            }
            else
                return Math.Round(dotProduct / magnitudeProduct, 2);
        }
    }
}
