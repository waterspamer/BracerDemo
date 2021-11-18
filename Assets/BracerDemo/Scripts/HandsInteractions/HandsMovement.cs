using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace BracerDemo.Scripts.HandsInteractions
{
    public class HandsMovement : MonoBehaviour
    {
        private void Start()
        {
            _parent = transform.parent;
        }

        public void SetParent(Transform transform)
        {
            var localPosition = this.transform.position;
            var localRotation = this.transform.rotation;

            
            this.transform.SetParent(transform);
            this.transform.position = localPosition;
            this.transform.rotation = localRotation;
        }

        private Transform _parent;
        
        public float stickTime = .5f;
        IEnumerator InterpolateLocalPose(Transform targetTransform)
        {
            float elapsedTime = 0;
            while (elapsedTime < stickTime)
            {
                transform.position = Vector3.Lerp(transform.position, targetTransform.position, (elapsedTime / stickTime));
                transform.rotation = Quaternion.Slerp(transform.rotation, targetTransform.rotation, (elapsedTime / stickTime));
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }

        public void StickToTarget(Transform target) => StartCoroutine(InterpolateLocalPose(target));

    }
}
