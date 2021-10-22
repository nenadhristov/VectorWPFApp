using System;
using System.Collections.Generic;

namespace VectorClass
{
    public struct VectorClass
    {
        /// <summary>
        /// Here I declare the components of the vector x,y,z as double
        /// and readonly access to the components of the vector
        /// </summary>
       public double x { get; }
       public double y { get; }
       public double z { get; }

        /// <summary>
        /// Here i initialize the components x,y,z
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public VectorClass (double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// This NegateVector method is used to negate a vector
        /// by multiplying the vector components with -1
        /// and then the method returns the negate vector
        /// </summary>
        /// <param name="Vector"></param>
        /// <returns>Vector(-x,-y,-z)</returns>
        public VectorClass NegateVector(VectorClass Vector)
        {

            double x;
            double y;
            double z;


            if (Vector.x > 0)
            {
                x = Vector.x * (-1);
            }
            else
            {
                x = Vector.x;
            }

            if (Vector.y > 0)
            {
                y = Vector.y * (-1);
            }
            else
            {
                y = Vector.y;
            }
            if (Vector.z > 0)
            {
                z = Vector.z * (-1);
            }
            else
            {
                z = Vector.z;
            }

            return new VectorClass(x,y,z);
        }
        
        /// <summary>
        /// This Addition method is used to compute the addition of two vectors
        /// and then returns a new vector as a result of the addition of the
        /// two vectors
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Vector1"></param>
        /// <returns>Vector(x,y,z)</returns>
        public VectorClass Addition(VectorClass Vector, VectorClass Vector1)
        {
            
            double x = Vector.x + Vector1.x;
            double y = Vector.y + Vector1.y;
            double z = Vector.z + Vector1.z;

            return new VectorClass(x,y,z);
        }

        /// <summary>
        /// This Substraction method is used to compute the substraction of two vectors
        /// and then returns a new vector as a result of the substraction of the
        /// two vectors
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Vector1"></param>
        /// <returns>Vector(x,y,z)</returns>
        public VectorClass Susbsraction(VectorClass Vector, VectorClass Vector1)
        {
            
         
            double x = Vector.x - Vector1.x;
            double y = Vector.y - Vector1.y;
            double z = Vector.z - Vector1.z;

            return new VectorClass(x,y,z);

        }

        /// <summary>
        /// This Multiply Method is used to multiply a given vector by a given scalar
        /// and then returns a new Vector as a result of multiplying the vector
        /// by the scalar
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Multiply"></param>
        /// <returns>Vector(x,y,z)</returns>

        public VectorClass Multiply(VectorClass Vector, double Multiply)
        {
            

            double x = Vector.x * Multiply;
            double y = Vector.y * Multiply;
            double z = Vector.z * Multiply;

            return new VectorClass(x,y,z);
        }

        /// <summary>
        /// This Divide Method is same as the Multiply method only difference is that
        /// is used to divide the vector by given scalar
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Multiply"></param>
        /// <returns>Vector(x,y,z)</returns>

        public VectorClass Divide(VectorClass Vector, double Multiply)
        {
            
           
            double x =Math.Round(Vector.x / Multiply,5);
            double y =Math.Round(Vector.y / Multiply,5);
            double z =Math.Round(Vector.z / Multiply,5);

            return new VectorClass(x,y,z);
        }
        /// <summary>
        /// This Multiply2Vectors method is used to multiply two given vestors by a given scalar
        /// a then save each vector in a list and return that list
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Vector1"></param>
        /// <param name="Multiply"></param>
        /// <returns>List</returns>
        public List<VectorClass> Multiply2Vectors(VectorClass Vector, VectorClass Vector1, double Multiply)
        {
            List<VectorClass> vectors = new List<VectorClass>();
            double x;
            double y;
            double z;
          
            x = Vector.x * Multiply;
            y = Vector.y * Multiply;
            z = Vector.z * Multiply;
            vectors.Add(new VectorClass(x,y,z));

            x = Vector1.x * Multiply;
            y = Vector1.y * Multiply;
            z = Vector1.z * Multiply;
            vectors.Add(new VectorClass(x, y, z));




            return vectors;
        }

        /// <summary>
        /// This CrossProduct method compute the cross product by given two vectors
        /// and store each result in a x, y, z variables and then return that vector
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Vector1"></param>
        /// <returns>Vector(x,y,z)</returns>

        public VectorClass CrossProduct(VectorClass Vector, VectorClass Vector1)
        {
            double x, y, z;

            x = Math.Round(Vector.y * Vector1.z - Vector.z * Vector1.y,5);
            y = Math.Round(Vector.z * Vector1.x - Vector.x * Vector1.z,5);
            z = Math.Round(Vector.x * Vector1.y - Vector.y * Vector1.x,5);

            return new VectorClass(x,y,z);
        }

        /// <summary>
        /// This Lenght method return the lenght or magnitude of a given vector.
        /// </summary>
        /// <param name="Vector"></param>
        /// <returns>Lenght</returns>

        public double Lenght(VectorClass Vector)
        {
            double lenght;

            lenght = Math.Pow(Vector.x, 2) + Math.Pow(Vector.y, 2) + Math.Pow(Vector.z, 2);

            lenght = Math.Sqrt(lenght);

            return Math.Round(lenght,5);
        }

        /// <summary>
        /// This Angle method compute the angle between two vectors,
        /// first it finds the dot product and than it finds the lenght of each vector,
        /// and then i used the formula to find the angle and convert it from radians to degrees
        /// so the return angle will be in degrees
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Vector1"></param>
        /// <returns>angle</returns>
        public double Angle(VectorClass Vector, VectorClass Vector1)
        {
            VectorClass obj = new VectorClass();
            double dotProducts;
            dotProducts = (Vector.x * Vector1.x) + (Vector.y * Vector1.y) + (Vector.z * Vector1.z);
            double magnitudeVector = obj.Lenght(Vector);
            double magnitudeVector1 = obj.Lenght(Vector1);
            double magnitude = magnitudeVector * magnitudeVector1;

            double dot_magnitude = dotProducts / magnitude;
            double a = (Math.Acos(dot_magnitude));
            a *= (180 / Math.PI);

            // Console.Write("The angle is :" + a + "°");

            return Math.Round(a,5);
        }

        /// <summary>
        /// This EqualOrNot method check if a given two vectors are equal or not.
        /// So first I find the lenght of each vector and then the direction angles for each component x, y, z.
        /// If vectors are equal the method will return true, otherwise false.
        /// </summary>
        /// <param name="Vector"></param>
        /// <param name="Vector1"></param>
        /// <returns>bool(true/false)</returns>


        public bool EqualOrNot(VectorClass Vector, VectorClass Vector1)
        {
            VectorClass obj = new VectorClass();
            double lengh1 = obj.Lenght(Vector);
            double lengh2 = obj.Lenght(Vector1);

            double anglea = Math.Acos(Vector.x / lengh1) * (180 / Math.PI);
            double angleb = Math.Acos(Vector.y / lengh1) * (180 / Math.PI);
            double anglez = Math.Acos(Vector.z / lengh1) * (180 / Math.PI);

            double anglea1 = Math.Acos(Vector1.x / lengh2) * (180 / Math.PI);
            double angleb1 = Math.Acos(Vector1.y / lengh2) * (180 / Math.PI);
            double anglez1 = Math.Acos(Vector1.z / lengh2) * (180 / Math.PI);

            if (lengh1 == lengh2 && anglea == anglea1 && angleb==angleb1 && anglez == anglez1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}
