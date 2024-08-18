using System;
using System.Numerics;

namespace DarknetHaxor
{
    internal static class MathUtils
    {
        const float SMALL_float = 0.0000000001f;

        internal static Quaternion GetRotationToLocation(Vector3 targetLocation, float y_bias, Vector3 myLoc)
        {
            Vector3 forwards = targetLocation + new Vector3(0, y_bias, 0) - myLoc;
            Vector3 upwards = new Vector3(0, 1, 0);

            return LookRotation(forwards, upwards);
        }

        internal static float QuaternionToAngle(Quaternion quaternion)
        {
            // Convert quaternion to Euler angles
            Vector3 euler = QuaternionToEulerAngles(quaternion);

            // Return the Yaw angle (around Y-axis)
            return euler.Y; // Yaw angle in radians
        }

        static Vector3 QuaternionToEulerAngles(Quaternion q)
        {
            // Extract Euler angles from quaternion
            float pitch = MathF.Asin(2 * (q.Y * q.Z + q.W * q.X));
            float yaw = MathF.Atan2(2 * (q.W * q.Y - q.X * q.Z), 1 - 2 * (q.Y * q.Y + q.Z * q.Z));
            float roll = MathF.Atan2(2 * (q.X * q.Y + q.W * q.Z), 1 - 2 * (q.Y * q.Y + q.Z * q.Z));

            return new Vector3(pitch, yaw, roll);
        }

        static Quaternion LookRotation(Vector3 forwards, Vector3 upwards)
        {
            forwards = Normalized(forwards);
            upwards = Normalized(upwards);

            if (SqrMagnitude(forwards) < SMALL_float || SqrMagnitude(upwards) < SMALL_float)
                return Quaternion.Identity;

            if (1 - Math.Abs(Vector3.Dot(forwards, upwards)) < SMALL_float)
                return FromToRotation(forwards, upwards);

            Vector3 right = Normalized(Vector3.Cross(upwards, forwards));
            upwards = Vector3.Cross(forwards, right);

            Quaternion quaternion;

            float radicand = right.X + upwards.Y + forwards.Z;

            if (radicand > 0)
            {
                quaternion.W = MathF.Sqrt(1f + radicand) * 0.5f;
                float recip = 1f / (4f * quaternion.W);
                quaternion.X = (upwards.Z - forwards.Y) * recip;
                quaternion.Y = (forwards.X - right.Z) * recip;
                quaternion.Z = (right.Y - upwards.X) * recip;
            }
            else if (right.X >= upwards.Y && right.X >= forwards.Z)
            {
                quaternion.X = MathF.Sqrt(1f + right.X - upwards.Y - forwards.Z) * 0.5f;
                float recip = 1f / (4f * quaternion.X);
                quaternion.W = (upwards.Z - forwards.Y) * recip;
                quaternion.Z = (forwards.X + right.Z) * recip;
                quaternion.Y = (right.Y + upwards.X) * recip;
            }
            else if (upwards.Y > forwards.Z)
            {
                quaternion.Y = MathF.Sqrt(1f - right.X + upwards.Y - forwards.Z) * 0.5f;
                float recip = 1f / (4f * quaternion.Y);
                quaternion.Z = (upwards.Z + forwards.Y) * recip;
                quaternion.W = (forwards.X - right.Z) * recip;
                quaternion.X = (right.Y + upwards.X) * recip;
            }
            else
            {
                quaternion.Z = MathF.Sqrt(1f - right.X - upwards.Y + forwards.Z) * 0.5f;
                float recip = 1f / (4f * quaternion.Z);
                quaternion.Y = (upwards.Z + forwards.Y) * recip;
                quaternion.X = (forwards.X + right.Z) * recip;
                quaternion.W = (right.Y - upwards.X) * recip;
            }
            return quaternion;
        }

        static Quaternion FromToRotation(Vector3 forwards, Vector3 upwards)
        {
            var dot = Vector3.Dot(forwards, upwards);
            var k = MathF.Sqrt(SqrMagnitude(forwards) * SqrMagnitude(upwards));

            if (Math.Abs(dot / k + 1) < 0.00001)
            {
                var ortho = Orthogonal(forwards);
                return new Quaternion(Normalized(ortho), 0);
            }

            var cross = Vector3.Cross(forwards, upwards);
            return Normalized(new Quaternion(cross, dot + k));
        }

        static Quaternion Normalized(Quaternion rotation)
        {
            float norm = Norm(rotation);
            return new Quaternion(rotation.X / norm, rotation.Y / norm, rotation.Z / norm, rotation.W / norm);
        }

        static float Norm(Quaternion rotation)
        {
            return MathF.Sqrt(rotation.X * rotation.X +
                        rotation.Y * rotation.Y +
                        rotation.Z * rotation.Z +
                        rotation.W * rotation.W);
        }

        static Vector3 Orthogonal(Vector3 v)
        {
            return v.Z < v.X ? new Vector3(v.Y, -v.X, 0) : new Vector3(0, -v.Z, v.Y);
        }

        static Vector3 Normalized(Vector3 vector)
        {
            var mag = Magnitude(vector);
            if (mag == 0)
                return Vector3.Zero;
            return vector / mag;
        }

        static float Magnitude(Vector3 vector)
        {
            return MathF.Sqrt(SqrMagnitude(vector));
        }

        static float SqrMagnitude(Vector3 v)
        {
            return v.X * v.X + v.Y * v.Y + v.Z * v.Z;
        }
    }
}
