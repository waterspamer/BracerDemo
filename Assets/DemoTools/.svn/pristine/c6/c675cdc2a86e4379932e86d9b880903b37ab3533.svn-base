using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayTarget : MonoBehaviour {
    private const float MovementThreshold = 0.001f;

    public event System.Action<ReplayTarget, bool> ActiveStateChangeEvent;

    private Vector3 _lastPosition = Vector3.zero;
    private Quaternion _lastRotation = Quaternion.identity;

    private void OnEnable() {
        if (ActiveStateChangeEvent != null) {
            ActiveStateChangeEvent(this, true);
        }
    }

    private void OnDisable() {
        if (ActiveStateChangeEvent != null) {
            ActiveStateChangeEvent(this, false);
        }
    }

    public bool PositionHasChanged() {
        var position = transform.position;

        if ((position - _lastPosition).sqrMagnitude > MovementThreshold * MovementThreshold) {
            _lastPosition = position;
            return true;
        }

        return false;
    }

    public bool RotationHasChanged() {
        var rotation = transform.rotation;

        if ((rotation.eulerAngles - _lastRotation.eulerAngles).sqrMagnitude > MovementThreshold * MovementThreshold) {
            _lastRotation = rotation;
            return true;
        }

        return false;
    }

    public void Move(Vector3 position, Quaternion rotation) {
        transform.position = position;
        transform.rotation = rotation;
    }
}
