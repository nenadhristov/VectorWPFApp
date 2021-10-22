using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VectorClass.UnitTests
{
    [TestClass]
    public class VectorClassTests
    {
        [TestMethod]
        public void EqualOrNot()
        {
            VectorClass vector = new VectorClass();
            
            VectorClass test = new VectorClass(30.1,40.1,50.1);

            VectorClass test1 = new VectorClass(30.1, 40.1, 50.1);

            bool expected = true;

            Assert.AreEqual(expected, vector.EqualOrNot(test,test1));

            

        }

       
        [DataTestMethod]
        [DataRow(-30.1,-40.1,-50.1)]
        public void NegateVector(double cord1, double cord2, double cord3)
        {
            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(30.1, 40.1, 50.1);
            VectorClass expected = new VectorClass(cord1, cord2, cord3);
            vector = vector.NegateVector(vector1);

            Assert.AreEqual(expected, vector);

        }

        [DataTestMethod]
        [DataRow(30, 35, 41)]
        public void AdditionVector(double cord1, double cord2, double cord3)
        {
            VectorClass vector = new VectorClass(0,0,0);
            VectorClass vector1 = new VectorClass(20, 30, 40);
            VectorClass vector2 = new VectorClass(10, 5, 1);

            vector = vector.Addition(vector1,vector2);
            
            Assert.AreEqual(cord1, vector.x);
            Assert.AreEqual(cord2, vector.y);
            Assert.AreEqual(cord3, vector.z);

        }

        [DataTestMethod]
        [DataRow(-25, -40, -40)]
        public void SubstractionVector(double cord1, double cord2, double cord3)
        {
            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(20, 30, 40);
            VectorClass vector2 = new VectorClass(45, 70, 80);

            vector = vector.Susbsraction(vector1, vector2);

            Assert.AreEqual(cord1, vector.x);
            Assert.AreEqual(cord2, vector.y);
            Assert.AreEqual(cord3, vector.z);

        }

        [DataTestMethod]
        [DataRow(1500, 2250, 3000)]
        public void MultiplyVector(double cord1, double cord2, double cord3)
        {
            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(20, 30, 40);
            vector = vector.Multiply(vector1,75);

            Assert.AreEqual(cord1, vector.x);
            Assert.AreEqual(cord2, vector.y);
            Assert.AreEqual(cord3, vector.z);

        }

        [DataTestMethod]
        [DataRow(0.26667, 0.4, 0.53333)]
        public void DevideVector(double cord1, double cord2, double cord3)
        {
            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(20, 30, 40);
            vector = vector.Divide(vector1, 75);

            Assert.AreEqual(cord1, vector.x);
            Assert.AreEqual(cord2, vector.y);
            Assert.AreEqual(cord3, vector.z);

        }

        [DataTestMethod]
        [DataRow(8, -6, -1)]
        public void CrossProductVector (double cord1, double cord2, double cord3)
        {
            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(1, 1, 2);
            VectorClass vector2 = new VectorClass(0, -1, 6);
            vector = vector.CrossProduct(vector1, vector2);

            Assert.AreEqual(cord1, vector.x);
            Assert.AreEqual(cord2, vector.y);
            Assert.AreEqual(cord3, vector.z);
        }

        [DataTestMethod]
        [DataRow(4.15129)]
        public void AngleVector(double angle)
        {
            double a;
            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(20, 30, 40);
            VectorClass vector2 = new VectorClass(45, 70, 80);
            a = vector.Angle(vector1, vector2);

            Assert.AreEqual(angle, a);
         
        }

        [DataTestMethod]
        [DataRow(80, 120, 160)]
        public void Multiply2Vectors(double cord1, double cord2, double cord3)
        {
            List<VectorClass> items = new List<VectorClass>();

            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(20, 30, 40);
            VectorClass vector2 = new VectorClass(20, 30, 40);
            items = vector.Multiply2Vectors(vector1, vector2, 4);

            foreach(VectorClass obj in items)
            {
                Assert.AreEqual(cord1, obj.x);
                Assert.AreEqual(cord2, obj.y);
                Assert.AreEqual(cord3, obj.z);

            }

        }

        [DataTestMethod]
        [DataRow(53.85165)]
        public void LenghtOfVectors(double check)
        {
            double lenght;

            VectorClass vector = new VectorClass();
            VectorClass vector1 = new VectorClass(20, 30, 40);

            lenght = vector.Lenght(vector1);

            Assert.AreEqual(check, lenght);

            

        }





































    }
}
