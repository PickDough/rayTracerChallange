using System;
using rayTracerChallange.Tuples;
using Xunit;

namespace rayTracerTests.Tuples
{
	public class VectorTests
	{
		[Fact]
		public void Create()
		{
			var v = new Vector(1.0f, 2.0f, 3.0f);

			Assert.IsType<Vector>(v);
		}

	}
}

