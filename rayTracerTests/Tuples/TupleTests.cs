using System;
using rayTracerChallange.Tuples;
using Xunit;

namespace rayTracerTests.Tuples
{
	public class TupleTests
	{
        readonly RTuple v;
        readonly RTuple u;

		public TupleTests()
        {
			v = new RTuple(1.0f, 2.0f, 3.0f);
			u = new RTuple(4.0f, 5.0f, 6.0f);
        }

		[Fact]
		public void Add()
		{
			Assert.Equal(new RTuple(5.0f, 7.0f, 9.0f), v + u);
		}

        [Fact]
		public void Subtract()
        {
			Assert.Equal(new RTuple(-3.0f, -3.0f, -3.0f), v - u);
        }

	}
}

