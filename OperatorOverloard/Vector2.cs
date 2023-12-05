using System;

namespace OperatorOverload
{
    public struct Vector2
    {
        // Vector coordinates X, Y
        public float X { get; }
        public float Y { get; }
        public float Magnitude { get; }

        // Constructor
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;

            Magnitude = MathF.Sqrt(MathF.Pow(X, 2) + MathF.Pow(Y, 2));
        }


        public static implicit operator Vector3(Vector2 v) =>
            new Vector3(v.X, v.Y, 0);       

        public Vector3 ToVector3() =>
            new Vector3(X, Y, 0);



        public static Vector2 operator +(Vector2 v1, Vector2 v2) =>
            new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        
        public static Vector2 operator -(Vector2 v1, Vector2 v2) =>
            new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        
        public static Vector2 operator -(Vector2 v) =>
            new Vector2(-v.X, -v.Y);
        
        public static Vector2 operator *(Vector2 v, float scalar) =>
            new Vector2(v.X * scalar, v.Y * scalar);
        
        public static Vector2 operator /(Vector2 v, float scalar) =>
            new Vector2(v.X * scalar, v.Y * scalar);


        public static bool operator <(Vector2 v1, Vector2 v2) =>
            v1.Magnitude < v2.Magnitude;

        public static bool operator >(Vector2 v1, Vector2 v2) =>
            v1.Magnitude > v2.Magnitude;

        public static bool operator ==(Vector2 v1, Vector2 v2) =>
            v1.Magnitude == v2.Magnitude;

        public static bool operator !=(Vector2 v1, Vector2 v2) =>
            v1.Magnitude != v2.Magnitude;

        public static bool operator <=(Vector2 v1, Vector2 v2) =>
            v1.Magnitude <= v2.Magnitude;

        public static bool operator >=(Vector2 v1, Vector2 v2) =>
            v1.Magnitude >= v2.Magnitude;

        public override string ToString() =>
            $"({X}, {Y})";
    }
}
