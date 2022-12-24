using UnityEngine;

namespace Utils
{
    public static class VectorExt
    {
        public static bool IsValueInRange(this Vector2 minMax, float value) => 
            value <= minMax.y && value >= minMax.x;

        public static bool IsNotInRange(this Vector2 minMax, float value) => 
            value > minMax.y && value < minMax.x;
        
        public static float RangedRandom(this Vector2 range) => 
            Random.Range(range.x, range.y);

        public static float TakeBetween(this Vector2 range, float percent) => 
            Mathf.Lerp(range.x, range.y, percent);
        
        public static float TakeBetweenUnclamped(this Vector2 range, float percent) => 
            Mathf.LerpUnclamped(range.x, range.y, percent);

        public static Vector3 InvertHorizontal(this Vector3 vector)
        {
            var x = vector.x;
            vector.x = vector.z;
            vector.z = x;
            return vector;
        }
        
        public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
        {
            var ab = b     - a;
            var av = value - a;
            return Vector3.Dot(av, ab) / Vector3.Dot(ab, ab);
        }
    }
}