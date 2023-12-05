using System;

namespace OperatorOverload
{
    public struct Vector3
    {
        // Vector coordinates X, Y, Z
        public float X { get; }
        public float Y { get; }
        public float Z { get; }
        public float Magnitude { get; }

        // Constructor
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;

            Magnitude = MathF.Sqrt(MathF.Pow(X, 2) + MathF.Pow(Y, 2) + MathF.Pow(Z, 2));
        }

        
        public static explicit operator Vector2(Vector3 v) =>
            new Vector2(v.X, v.Y);

        public Vector2 ToVector2() =>
            new Vector2(X, Y);



        public static Vector3 operator +(Vector3 v1, Vector3 v2) =>
            new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        
        public static Vector3 operator -(Vector3 v1, Vector3 v2) =>
            new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        
        public static Vector3 operator -(Vector3 v) =>
            new Vector3(-v.X, -v.Y, -v.Z);
        
        public static Vector3 operator *(Vector3 v, float scalar) =>
            new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);
        
        public static Vector3 operator /(Vector3 v, float scalar) =>
            new Vector3(v.X * scalar, v.Y * scalar, v.Z * scalar);


        public static bool operator <(Vector3 v1, Vector3 v2) =>
            v1.Magnitude < v2.Magnitude;

        public static bool operator >(Vector3 v1, Vector3 v2) =>
            v1.Magnitude > v2.Magnitude;

        public static bool operator ==(Vector3 v1, Vector3 v2) =>
            v1.Magnitude == v2.Magnitude;

        public static bool operator !=(Vector3 v1, Vector3 v2) =>
            v1.Magnitude != v2.Magnitude;

        public static bool operator <=(Vector3 v1, Vector3 v2) =>
            v1.Magnitude <= v2.Magnitude;

        public static bool operator >=(Vector3 v1, Vector3 v2) =>
            v1.Magnitude >= v2.Magnitude;

        public override string ToString() =>
            $"({X}, {Y}, {Z})";
    }
}
