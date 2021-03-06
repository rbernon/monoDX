/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2013 Alistair Leslie-Hughes
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
 * the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using NUnit.Framework;
using Microsoft.DirectX;

namespace Test.Microsoft.DirectX
{
	[TestFixture()]
	public class TestVector3
	{
		[Test()]
		public void TestEmpty ()
		{
			Vector3 v3 = Vector3.Empty;
			Assert.AreEqual(0.0f, v3.X);
			Assert.AreEqual(0.0f, v3.Y);
			Assert.AreEqual(0.0f, v3.Z);
		}

		[Test()]
		public void TestDot ()
		{
			Vector3 rhs = new Vector3(2.0f, 2.0f, 2.0f);
			Vector3 lhs = new Vector3(2.0f, 2.0f, 2.0f);
			float result;

			result = Vector3.Dot(lhs, rhs);
			Assert.AreEqual(12.0f, result);
		}

		[Test()]
		public void TestCross ()
		{
			Vector3 rhs = new Vector3(3.0f, 3.0f, 3.0f);
			Vector3 lhs = new Vector3(2.0f, 2.0f, 2.0f);
			Vector3 result;

			result = Vector3.Cross(lhs, rhs);
			Assert.AreEqual(0.0f, result.X);
			Assert.AreEqual(0.0f, result.Y);
			Assert.AreEqual(0.0f, result.Z);
		}

		[Test()]
		public void TestLength ()
		{
			Vector3 v1 = new Vector3(3.0f, 3.0f, 3.0f);
			Vector3 v2 = new Vector3(2.0f, 2.0f, 2.0f);
			float result;

			result = v1.Length();
			Assert.AreEqual(5.19615221f, result);

			result = Vector3.Length(v2);
			Assert.AreEqual(3.46410155f, result);
		}
	}
}


