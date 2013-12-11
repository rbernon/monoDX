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
using System.Collections;

namespace Microsoft.DirectX.DirectInput
{
	public class ActionCollection : IEnumerable, ICloneable
	{
		public Action this [int index] {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int Count {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsReadOnly {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsFixedSize {
			
			get {
				throw new NotImplementedException ();
			}
		}

		public int Add (Action value)
		{
			throw new NotImplementedException ();
		}

		public void CopyTo (Array data, int index)
		{
			throw new NotImplementedException ();
		}

		public void Clear ()
		{
			throw new NotImplementedException ();
		}
		
		public bool Contains (Action value)
		{
			throw new NotImplementedException ();
		}

		public int IndexOf (Action value)
		{
			throw new NotImplementedException ();
		}

		public void Insert (int index, Action value)
		{
			throw new NotImplementedException ();
		}

		public void Remove (Action value)
		{
			throw new NotImplementedException ();
		}

		public void RemoveAt (int index)
		{
			throw new NotImplementedException ();
		}

		public IEnumerator GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		public object Clone ()
		{
			throw new NotImplementedException ();
		}
	}
}

