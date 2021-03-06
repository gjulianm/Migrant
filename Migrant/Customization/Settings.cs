/*
  Copyright (c) 2012 Ant Micro <www.antmicro.com>

  Authors:
   * Konrad Kruczynski (kkruczynski@antmicro.com)
   * Piotr Zierhoffer (pzierhoffer@antmicro.com)

  Permission is hereby granted, free of charge, to any person obtaining
  a copy of this software and associated documentation files (the
  "Software"), to deal in the Software without restriction, including
  without limitation the rights to use, copy, modify, merge, publish,
  distribute, sublicense, and/or sell copies of the Software, and to
  permit persons to whom the Software is furnished to do so, subject to
  the following conditions:

  The above copyright notice and this permission notice shall be
  included in all copies or substantial portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
  MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
  LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
  OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
  WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;


namespace AntMicro.Migrant.Customization
{
	/// <summary>
	/// Contains serialization settings.
	/// </summary>
	/// 	
	// The reason settings are serializable is to enable tests regarding version tolerant serialization
	[Serializable]
	public sealed class Settings
	{
		/// <summary>
		/// Gets the method used for serialization.
		/// </summary>
		public Method SerializationMethod { get; private set; }

		/// <summary>
		/// Gets the method used for deserialization.
		/// </summary>
		public Method DeserializationMethod { get; private set; }

		/// <summary>
		/// Specifies how much the layout of the serialized class can differ from the version
		/// that is available when that data is deserialized.
		/// </summary>
		public VersionToleranceLevel VersionTolerance { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AntMicro.Migrant.Customization.Settings"/> class.
		/// </summary>
		/// <param name='serializationMethod'>
		/// Method used for serialization.
		/// </param>
		/// <param name='deserializationMethod'>
		/// Method used for deserialization.
		/// </param>
		/// <param name='versionTolerance'>
		/// Specifies the possible level of difference between class layout when it was serialized and in the
		/// moment of deserialization.
		/// </param>
		public Settings(Method serializationMethod = Method.Generated, Method deserializationMethod = Method.Generated, VersionToleranceLevel versionTolerance = 0)
		{
			SerializationMethod = serializationMethod;
			DeserializationMethod = deserializationMethod;
			VersionTolerance = versionTolerance;
		}
	}
}

