using UnityEngine;

namespace BaboonAndCo.Patterns
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; protected set; }

        private void Awake()
        {
            foreach (var instance in FindObjectsOfType(typeof(T), false))
            {
                if (instance != this)
                {
                    var go = (instance as T)!.gameObject;
                    WarnAboutDuplicate(go);
                    DestroyImmediate(go);
                }
            }

            Instance = this as T;
        }

        private void OnApplicationQuit()
        {
            Instance = null;
        }

        private void WarnAboutDuplicate(GameObject instance)
        {
            Debug.LogError
            (
            "Found Singleton duplicate in scene hierarchy. " +
                $"Type of: <color=red>{typeof(T).Name}</color> " +
                $"and GO name: <color=red>{instance.name}</color>!"
            );
        }
    }
}