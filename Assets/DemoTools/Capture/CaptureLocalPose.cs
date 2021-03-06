using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CaptureLocalPose : Capture {

    private Vector3 _previousLocalPosition;
    private Quaternion _previousLocalRotation;

    protected override void OnFrame(){
        
        Debug.Log("CaptureLocalPose — OnFrame");

        DeclareAndFind(gameObject);
        
        if (_previousLocalRotation != transform.localRotation || _previousLocalPosition != transform.localPosition) {

            _previousLocalRotation = transform.localRotation;
            _previousLocalPosition = transform.localPosition;

            WriteGet().AppendLine($".SetLocalPose({transform.localPosition.x}f,{transform.localPosition.y}f,{transform.localPosition.z}f,{transform.localRotation.x}f,{transform.localRotation.y}f,{transform.localRotation.z}f,{transform.localRotation.w}f);");

            //WriteGet().AppendLine($".transform.localRotation = new Quaternion ({transform.localRotation.x}f,{transform.localRotation.y}f,{transform.localRotation.z}f, {transform.localRotation.w}f);");
        }
    }
}
