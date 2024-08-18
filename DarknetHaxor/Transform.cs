using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DarknetHaxor
{
    internal static class Transform
    {
        internal struct TMatrix
        {
            internal Vector4 position;
            internal Quaternion rotation;
            internal Vector4 scale;
        };

        internal static bool GetNodePosition(uint nodeTransform, out Vector3 result)
        {
            var transform = InternalMemory.Read<uint>(nodeTransform + 0x8, out var transformValue);
            if (!transform)
            {
                result = Vector3.Zero;
                return false;
            }

            return GetPosition(transformValue, out result);
        }

        internal static bool GetPosition(uint transform, out Vector3 pos)
        {
            pos = Vector3.Zero;

            var transformObj = InternalMemory.Read<uint>(transform + 0x8, out var transformObjValue);
            if (!transformObj)
            {
                return false;
            }

            var index = InternalMemory.Read<uint>(transformObjValue + 0x24, out var indexValue);
            var matrix = InternalMemory.Read<uint>(transformObjValue + 0x20, out var matrixValue);
            if (!index || !matrix)
            {
                return false;
            }

            var matrixList = InternalMemory.Read<uint>(matrixValue + 0x10, out var matrixListValue);
            var matrixIndices = InternalMemory.Read<uint>(matrixValue + 0x14, out var matrixIndicesValue);
            if (!matrixList || !matrixIndices)
            {
                return false;
            }

            var result = InternalMemory.Read<Vector3>(indexValue * 0x30 + matrixListValue, out var resultValue);
            if (!result)
            {
                return false;
            }

            var maxTries = 50;
            var tries = 0;

            var transformIndex = InternalMemory.Read<int>((uint)((indexValue * 0x4) + matrixIndicesValue), out var transformIndexValue);

            if (!transformIndex)
                return false;

            while (transformIndexValue >= 0)
            {
                tries++;

                if (tries == maxTries) break;
                var tMatrix = InternalMemory.Read<TMatrix>((uint)(0x30 * transformIndexValue + matrixListValue), out var tMatrixValue);
                if (!tMatrix)
                {
                    return false;
                }

                float rotX = tMatrixValue.rotation.X;
                float rotY = tMatrixValue.rotation.Y;
                float rotZ = tMatrixValue.rotation.Z;
                float rotW = tMatrixValue.rotation.W;

                float scaleX = resultValue.X * tMatrixValue.scale.X;
                float scaleY = resultValue.Y * tMatrixValue.scale.Y;
                float scaleZ = resultValue.Z * tMatrixValue.scale.Z;

                resultValue.X = (float)(tMatrixValue.position.X + scaleX +
                            (scaleX * ((rotY * rotY * -2.0) - (rotZ * rotZ * 2.0))) +
                            (scaleY * ((rotW * rotZ * -2.0) - (rotY * rotX * -2.0))) +
                            (scaleZ * ((rotZ * rotX * 2.0) - (rotW * rotY * -2.0))));
                resultValue.Y = (float)(tMatrixValue.position.Y + scaleY +
                            (scaleX * ((rotX * rotY * 2.0) - (rotW * rotZ * -2.0))) +
                            (scaleY * ((rotZ * rotZ * -2.0) - (rotX * rotX * 2.0))) +
                            (scaleZ * ((rotW * rotX * -2.0) - (rotZ * rotY * -2.0))));
                resultValue.Z = (float)(tMatrixValue.position.Z + scaleZ +
                            (scaleX * ((rotW * rotY * -2.0) - (rotX * rotZ * -2.0))) +
                            (scaleY * ((rotY * rotZ * 2.0) - (rotW * rotX * -2.0))) +
                            (scaleZ * ((rotX * rotX * -2.0) - (rotY * rotY * 2.0))));

                var transformResult = InternalMemory.Read<int>((uint)(transformIndexValue * 0x4 + matrixIndicesValue), out transformIndexValue);
                if (!transformResult)
                {
                    return false;
                }
            }

            pos = resultValue;

            return tries != maxTries;
        }
    }

}
