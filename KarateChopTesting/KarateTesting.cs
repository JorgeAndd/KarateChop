﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using KarateChop;

namespace KarateChopTesting
{
	[TestClass]
	public class KarateTesting
	{
		// public Karate karate = new karate();
		public Karate karate = new RecursiveKarate();

		[TestMethod]
		public void TestChop1(){
			Assert.AreEqual(-1, karate.Chop(3, new int[] { }));
		}

		[TestMethod]
		public void TestChop2()
		{
			Assert.AreEqual(-1, karate.Chop(3, new int[] { 1 }));
		}

		[TestMethod]
		public void TestChop3()
		{
			Assert.AreEqual(0, karate.Chop(1, new int[] { 1 }));
		}

		[TestMethod]
		public void TestChop4()
		{
			Assert.AreEqual(0, karate.Chop(1, new int[] { 1, 3, 5 }));

		}

		[TestMethod]
		public void TestChop5()
		{
			Assert.AreEqual(1, karate.Chop(3, new int[] { 1, 3, 5 }));

		}

		[TestMethod]
		public void TestChop6()
		{
			Assert.AreEqual(2, karate.Chop(5, new int[] { 1, 3, 5 }));

		}

		[TestMethod]
		public void TestChop7()
		{
			Assert.AreEqual(-1, karate.Chop(0, new int[] { 1, 3, 5 }));

		}

		[TestMethod]
		public void TestChop8()
		{
			Assert.AreEqual(-1, karate.Chop(2, new int[] { 1, 3, 5 }));

		}

		[TestMethod]
		public void TestChop9()
		{
			Assert.AreEqual(-1, karate.Chop(4, new int[] { 1, 3, 5 }));
		}

		[TestMethod]
		public void TestChop10()
		{
			Assert.AreEqual(-1, karate.Chop(6, new int[] { 1, 3, 5 }));
		}

		[TestMethod]
		public void TestChop11()
		{
			Assert.AreEqual(0, karate.Chop(1, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop12()
		{
			Assert.AreEqual(1, karate.Chop(3, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop13()
		{
			Assert.AreEqual(2, karate.Chop(5, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop14()
		{
			Assert.AreEqual(3, karate.Chop(7, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop15()
		{
			Assert.AreEqual(-1, karate.Chop(0, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop16()
		{
			Assert.AreEqual(-1, karate.Chop(2, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop17()
		{
			Assert.AreEqual(-1, karate.Chop(4, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop18()
		{
			Assert.AreEqual(-1, karate.Chop(6, new int[] { 1, 3, 5, 7 }));

		}

		[TestMethod]
		public void TestChop19()
		{
			Assert.AreEqual(-1, karate.Chop(8, new int[] { 1, 3, 5, 7 }));
		}			
	}
}

