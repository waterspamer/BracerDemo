using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureLocalRotation : Capture {

    private Quaternion _previousRotation;

    protected override void OnFrame() {
        
        DeclareAndFind(gameObject);

        if (_previousRotation != transform.localRotation) {
            _previousRotation = transform.localRotation;
            WriteGet().AppendLine($".transform.localRotation = new Quaternion ({transform.localRotation.x}f,{transform.localRotation.y}f,{transform.localRotation.z}f, {transform.localRotation.w}f);");
        }
        
    }

}
