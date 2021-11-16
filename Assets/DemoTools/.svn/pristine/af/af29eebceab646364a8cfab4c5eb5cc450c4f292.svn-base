using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLogger : MonoBehaviour {
    private int _updateCount = 0;
    private int _fixedUpdateCount = 0;
    private float _startTime = -1f;
    private float _fps = 60f;

    private void Start() {
        _startTime = Time.realtimeSinceStartup;
    }

    private void Update() {
        const float weight = 0.1f;
        float dt = Time.deltaTime;
        _fps = _fps * (1.0f - weight) + (1.0f / dt) * weight;

        if (_updateCount >= 100 && _updateCount % 100 == 0) {
            float elapsed = Time.realtimeSinceStartup - _startTime;
            Debug.LogFormat("Update rate: {0}; Fixed Update rate: {1}; FPS: {2}", (float)_updateCount / elapsed, (float)_fixedUpdateCount / elapsed, _fps);
        }

        _updateCount++;
    }

    private void FixedUpdate() {
        _fixedUpdateCount++;
    }
}
