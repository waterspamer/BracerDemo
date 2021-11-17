using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Antilatency.SDK
{
    public class Test : MonoBehaviour
    {
        public Bracer hand;
        public AltTracking altTracking;
        public Transform transformHand;
        public bool isHolding = false;
        

        void Start()
        {

        }

        void Update()
        {
            
        }

        private void Grab(TakeBall ball, Rigidbody rbBall)
        {
            ball.transform.SetParent(transformHand);
            rbBall.isKinematic = true;
            isHolding = true;
            ball.testTaking();
        }

        private void Throw(TakeBall ball, Rigidbody rbBall)
        {
            if (isHolding == true)
            {
                ball.transform.parent = null;
                rbBall.isKinematic = false;
                rbBall.useGravity = true;
                altTracking.GetRawTrackingState(out var trackingState);
                //Debug.Log("Velocity = " + trackingState.velocity);
                rbBall.velocity = trackingState.velocity * 3f;
                isHolding = false;
            }
        }

        private void OnTriggerStay(Collider collider)
        {
            TakeBall ball = collider.gameObject.GetComponent<TakeBall>();
            Rigidbody rbBall = collider.GetComponent<Rigidbody>();

            //Debug.Log("Value = " + touch);
            if (ball && (hand.CurrentTouchState == BracerTouchState.Pressed))
            {
                Grab(ball, rbBall);
            }
        }
        private void OnTriggerExit(Collider collider)
        {
            Rigidbody rbBall = collider.GetComponent<Rigidbody>();
            TakeBall ball = collider.gameObject.GetComponent<TakeBall>();
            Throw(ball, rbBall);
        }
    }
}

