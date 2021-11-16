using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureDestroy : Capture
{

    void OnDestroy() {
        if (!state.captureSettings.Enable) return;
        DeclareAndFind(gameObject);
        WriteGet().AppendLine(".SetActive(false);");
        output.AppendLine("DestroyImmediate(" + GetGet(gameObject) + ");");
    }

}
