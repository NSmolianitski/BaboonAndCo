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

        public static bool TryGetComponentInParent<T>(this Transform transform, out T component) where T : MonoBehaviour
        {
            component = transform.GetComponentInParent<T>();
            return component != null;
        }
    }
}