using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureLocalScale : Capture {

    private Vector3 _previousScale;

    protected override void OnFrame() {
        DeclareAndFind(gameObject);

        if (_previousScale != transform.localScale) {
            _previousScale = transform.localScale;
            WriteGet().AppendLine($".transform.localScale = new Vector3 ({transform.localScale.x}f,{transform.localScale.y}f,{transform.localScale.z}f);");
        }
        
    }

}
