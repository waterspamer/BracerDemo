using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace BracerDemo.Scripts.HandsInteractions
{
    public class TriggerEventInvoker : MonoBehaviour
    {

        public string otherTag;

        public UnityEvent triggerEnterEvent;
        public UnityEvent triggerExitEvent;

        
        private void OnTriggerEnter(Collider other) {
            if (other.CompareTag(otherTag))
                triggerEnterEvent?.Invoke();
        }

        private void OnTriggerExit(Collider other) {
            if (other.CompareTag(otherTag))
                triggerExitEvent?.Invoke();
        }
    }
}
