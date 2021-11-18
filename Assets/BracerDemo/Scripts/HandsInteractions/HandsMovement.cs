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
            var transform2 = this.transform;
            var localPosition = transform2.position;
            var localRotation = transform2.rotation;


            Transform transform1;
            (transform1 = this.transform).SetParent(transform);
            transform1.position = localPosition;
            transform1.rotation = localRotation;
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
