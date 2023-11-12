using System.Collections.Generic;
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

        public static T GetClosestTargetToUnit<T>(IEnumerable<T> targets, Transform unit) where T : MonoBehaviour
        {
            T bestTarget = null;
            float closestDistanceSqr = Mathf.Infinity;
            
            var currentPosition = unit.position;
            foreach(var target in targets)
            {
                var directionToTarget = target.transform.position - currentPosition;
                
                var sqrDirectionToTarget = directionToTarget.sqrMagnitude;
                if (sqrDirectionToTarget < closestDistanceSqr)
                {
                    closestDistanceSqr = sqrDirectionToTarget;
                    bestTarget = target;
                }
            }
     
            return bestTarget;
        }

        public static void RotateByDirection(Transform transform, Vector3 direction)
        {
            var toRotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = toRotation;
        }
    }
}