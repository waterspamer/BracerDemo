using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureLocalPosition : Capture {

    private Vector3 _previousLocalPosition;

    protected override void OnFrame() {

        DeclareAndFind(gameObject);

        if (_previousLocalPosition != transform.localPosition) {
            _previousLocalPosition = transform.localPosition;
            WriteGet().AppendLine($".transform.localPosition = new Vector3 ({transform.localPosition.x}f,{transform.localPosition.y}f,{transform.localPosition.z}f);");
        }
        
    }

}
