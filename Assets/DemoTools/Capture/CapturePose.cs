using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePose : Capture {

    private Vector3 _previousWorldPosition;
    private Quaternion _previousWorldRotation;

    protected override void OnFrame() {

        DeclareAndFind(gameObject);
        

        if (_previousWorldRotation != transform.rotation || _previousWorldPosition != transform.position) {

            // Отперентили чтобы позиция не зависела от родителя
            //transform.SetParent(null);

            _previousWorldRotation = transform.rotation;
            _previousWorldPosition = transform.position;
            
            WriteGet().AppendLine($".SetWorldPose({transform.position.x}f,{transform.position.y}f,{transform.position.z}f,{transform.rotation.x}f,{transform.rotation.y}f,{transform.rotation.z}f,{transform.rotation.w}f);");

            //WriteGet().AppendLine($".transform.rotation = new Quaternion ({transform.rotation.x}f,{transform.rotation.y}f,{transform.rotation.z}f, {transform.rotation.w}f);");
        }

    }

}
