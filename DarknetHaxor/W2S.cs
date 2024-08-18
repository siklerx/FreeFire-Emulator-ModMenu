using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DarknetHaxor
{
    internal static class W2S
    {
        internal static Vector2 WorldToScreen(Matrix4x4 viewMatrix, Vector3 pos, int width, int height)
        {
            var result = new Vector2(-1, -1);

            if (pos == null || viewMatrix == null)
                return result;

            var v9 = (pos.X * viewMatrix.M11) + (pos.Y * viewMatrix.M21) + (pos.Z * viewMatrix.M31) + viewMatrix.M41;
            var v10 = (pos.X * viewMatrix.M12) + (pos.Y * viewMatrix.M22) + (pos.Z * viewMatrix.M32) + viewMatrix.M42;
            var v12 = (pos.X * viewMatrix.M14) + (pos.Y * viewMatrix.M24) + (pos.Z * viewMatrix.M34) + viewMatrix.M44;

            if (v12 >= 0.001)
            {
                var v13 = width / 2f;
                var v14 = height / 2f;

                result.X = v13 + (v13 * v9) / v12;
                result.Y = v14 - (v14 * v10) / v12;
            }

            return result;
        }

    }
}
