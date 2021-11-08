using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_2P9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string exp_res = "ННД";
            string act_res = Program.Turn(Program.turn.none);
            Assert.AreEqual(exp_res, act_res, "Опс");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string exp_res = "НП";
            string act_res = Program.Turn(Program.turn.to_right);
            Assert.AreEqual(exp_res, act_res, "Опс");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string exp_res = "НЛ";
            string act_res = Program.Turn(Program.turn.to_left);
            Assert.AreEqual(exp_res, act_res, "Опс");
        }
        [TestMethod]
        public void TestMethod11()
        {
            string exp_res = "ННД";
            string act_res = Program.Turn((Program.turn)0);
            Assert.AreEqual(exp_res, act_res, "Опс");
        }

        [TestMethod]
        public void TestMethod22()
        {
            string exp_res = "НП";
            string act_res = Program.Turn((Program.turn)1);
            Assert.AreEqual(exp_res, act_res, "Опс");
        }

        [TestMethod]
        public void TestMethod33()
        {
            string exp_res = "НЛ";
            int command = 2;
            Program.turn turn = (Program.turn)command;
            string act_res = Program.Turn(turn);
            Assert.AreEqual(exp_res, act_res, "Опс");
        }
    }
}
