using System;
using Xunit;
using rayTracerChallange.Tuples;

namespace rayTracerTests.Tuples
{
	public class PointTest
	{
		[Fact]
		public void Create()
        {
            var p = new Point(1.0f, 2.0f, 3.0f);

			Assert.IsType<Point>(p);
        }
	}
}

