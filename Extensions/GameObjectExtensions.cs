using UnityEngine;

namespace BaboonAndCo.Extensions
{
    public static class GameObjectExtensions
    {
        public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T component) where T : MonoBehaviour
        {
            component = gameObject.GetComponentInParent<T>();
            return component != null;
        }
    }
}