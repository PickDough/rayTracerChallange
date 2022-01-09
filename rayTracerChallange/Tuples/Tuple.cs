using System;
namespace rayTracerChallange.Tuples
{
	public class RTuple: IEquatable<RTuple>
	{
		public RTuple(float x, float y, float z)
		{
            X = x;
            Y = y;
            Z = z;
        }

		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }

        public static RTuple operator +(RTuple a) => a;
        public static RTuple operator -(RTuple a) => new(-a.X, -a.Y, -a.Z);

        public static RTuple operator +(RTuple a, RTuple b) =>
            new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static RTuple operator -(RTuple a, RTuple b) =>
            a + (-b);

        public static RTuple operator *(RTuple a, float f) => new(f * a.X, f * a.Y, f * a.Z);
        public static RTuple operator *(float f, RTuple b) => b * f;

        public static RTuple operator /(RTuple a, float f) => a * (1 / f);
        public static RTuple operator /(float f, RTuple b) => b * (1/f);

        public static float Dot(RTuple a, RTuple b) => a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        public static RTuple Cross(RTuple a, RTuple b) =>
            new(a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X);


        public bool Equals(RTuple? p)
        {
            if (p is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            if (this.GetType() != p.GetType())
            {
                return false;
            }


            return CompareFloats(X, p.X) && CompareFloats(Y, p.Y) && CompareFloats(Z, p.Z);
        }

        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        private static bool CompareFloats(float a, float b, float eps = 0.0001f)
        {
            return Math.Abs(a - b) <= eps;
        }

    }
}

