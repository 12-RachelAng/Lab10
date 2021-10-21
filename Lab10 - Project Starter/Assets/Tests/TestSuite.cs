using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        //Addition
        [Test]
        public void TestAddition()
        {
            //Use the Assert Class to Test Conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            //Use the Assert Class to Test Conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        //Subtraction
        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            //Use the Assert Class to Test Conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        //Multiplication
        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            //Use the Assert Class to Test Conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        //Division
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(5, 2, "/");
            Assert.AreEqual(result, 2.5f);
        }

        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            //Use the Assert Class to Test Conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "/");
            Assert.AreEqual(result, 2.5f);
        }

        //Square Root
        [Test]
        public void TestSquareRoot()
        {
            result = Calculator.CalculatePair(5, 2, "Mathf.Sqrt");
            Assert.AreEqual(result, 0.0f);
        }

        [UnityTest]
        public IEnumerator TestUnitySquareRoot()
        {
            //Use the Assert Class to Test Conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "Mathf.Sqrt");
            Assert.AreEqual(result, 0.0f);
        }

        //Power
        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(5, 2, "Math.Pow");
            Assert.AreEqual(result, 0.0f);
        }

        [UnityTest]
        public IEnumerator TestUnityPowert()
        {
            //Use the Assert Class to Test Conditions
            //Use yield to skip a frame
            yield return null;

            result = Calculator.CalculatePair(5, 2, "Math.Pow");
            Assert.AreEqual(result, 0.0f);
        }
    }
}
