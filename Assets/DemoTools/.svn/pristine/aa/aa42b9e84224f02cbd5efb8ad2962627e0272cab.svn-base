using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSetParent : Capture {

    public Transform ParentTransform;

    protected override void OnFrame() {
        
        //Debug.Log("CaptureSetParent - OnFrame()");

        // кажется это надо выполнять один раз
        DeclareAndFind(gameObject);
        
        if (ParentTransform != transform.parent) {
            ParentTransform = transform.parent;

            if (transform.parent) {
                DeclareAndFind(transform.parent.gameObject);
                WriteGet().Append($".transform.parent = ");
                WriteGet(transform.parent.gameObject).AppendLine(".transform;");
            } else {
                WriteGet().Append($".transform.parent = null;");
            }

            //Debug.Log("CaptureSetParent !!!");

            //WriteGet().AppendLine($".transform.Set({transform.position.x}f,{transform.position.y}f,{transform.position.z}f,{transform.rotation.x}f,{transform.rotation.y}f,{transform.rotation.z}f,{transform.rotation.w}f);");

        }


    }


}
