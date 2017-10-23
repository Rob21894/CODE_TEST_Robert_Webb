using Microsoft.VisualStudio.TestTools.UnitTesting;
using CODE_TEST_RobertWebb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_TEST_RobertWebb.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestPolly()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() {1,26,51};
            CollectionAssert.AreEqual(expexted,test.SubtextMatches("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea","polly"));
        }


        [TestMethod()]
        public void Testpolly()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() { 1, 26, 51 };
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polly"));
        }

        [TestMethod()]
        public void Testll()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() { 3,28,53,78,82 };
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "ll"));
        }

        [TestMethod()]
        public void TesLl()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() { 3, 28, 53, 78, 82 };
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Ll"));
        }

        [TestMethod()]
        public void TestX()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() {};
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "X"));
        }
        [TestMethod()]
        public void TestPolx()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() { };
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea", "Polx"));
        }
        [TestMethod()]
        public void TestPeterPiper()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() {1,51};
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("Peter Piper picked a peck of pickled peppers. Did Peter Piper pick a peck of pickled peppers", "Peter"));
        }

        [TestMethod()]
        public void TestSheSellsSeaShells()
        {
            var test = new StringMatches();
            List<int> expexted = new List<int>() { 11, 28,70};
            CollectionAssert.AreEqual(expexted, test.SubtextMatches("She sells seashells by the seashore. The shells she sells are surely seashells", "sea"));
        }


    }
}