using UnityEngine;

namespace Utils
{
    public static class DirectionsExt
    {
        public static float Distance(this Transform origin, Transform target) => origin.RawHeading(target).magnitude;
        public static float Distance(this Vector3   origin, Transform target) => origin.RawHeading(target).magnitude;
        public static float Distance(this Transform origin, Vector3   target) => origin.RawHeading(target).magnitude;
        public static float Distance(this Vector3   origin, Vector3   target) => origin.RawHeading(target).magnitude;

        public static Vector3 Heading(this Transform origin, Transform target) => origin.RawHeading(target).normalized;
        public static Vector3 Heading(this Vector3   origin, Transform target) => origin.RawHeading(target).normalized;
        public static Vector3 Heading(this Transform origin, Vector3   target) => origin.RawHeading(target).normalized;
        public static Vector3 Heading(this Vector3   origin, Vector3   target) => origin.RawHeading(target).normalized;

        public static Vector3 RawHeading(this Transform origin, Transform target) => target.position - origin.position;
        public static Vector3 RawHeading(this Vector3   origin, Transform target) => target.position - origin;
        public static Vector3 RawHeading(this Transform origin, Vector3   target) => target          - origin.position;
        public static Vector3 RawHeading(this Vector3   origin, Vector3   target) => target          - origin;

        public static Vector3 MovementVector(this Transform target, ref Vector3 previousPosition, float sensitivity = 1, bool ignoreY = false)
        {
            var currentPosition = target.position;
            var vector = currentPosition - previousPosition;
            var movementVector   = Vector3.ClampMagnitude(vector * sensitivity, 1);
            if(ignoreY) movementVector.y = 0;
            previousPosition = currentPosition;
            return movementVector;
        }
    }
}