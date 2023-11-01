using UnityEngine;

namespace BaboonAndCo.Utils
{
    public static class TransformUtils
    {
        public static Vector3 GetUnitRelativeDirection(Transform transform, in Vector3 direction)
        {
            return (transform.right * direction.x)
                   + (transform.forward * direction.z);
        }
    }
}