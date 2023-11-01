using UnityEngine;

namespace BaboonAndCo.Extensions
{
    public static class TransformExtensions
    {
        public static void AlignWithParent(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = transform.parent.localRotation;
        }
    }
}