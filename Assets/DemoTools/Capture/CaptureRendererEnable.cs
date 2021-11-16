using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureRendererEnable : Capture
{
    public Renderer Renderer;
    private bool _enabled;

    //public bool DoDebug;

    protected override void OnFrame() {
        //if (DoDebug) {
        //    Debug.Log("Debug");
        //}
        DeclareAndFind(gameObject);
        if (_enabled != Renderer.enabled) {
            _enabled = Renderer.enabled;
            //WriteGet().AppendLine($".transform.localRotation = new Quaternion ({transform.rotation.x}f,{transform.rotation.y}f,{transform.rotation.z}f, {transform.rotation.w}f);");
            string enabledString = _enabled ? "true" : "false";
            WriteGet().AppendLine($".GetComponent<Renderer>().enabled = {enabledString};");
        }


    }

}
