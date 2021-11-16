using UnityEditor;
using UnityEngine;

public class CaptureCreate : Capture {

    protected override void Awake() {
        base.Awake();
        if (!state.captureSettings.Enable) return;

        //if (!CaptureStarted) return;
        if (!this.enabled) return; // если галочка выключена

        var clone = "(Clone)";
        string prefabName = "";
        if (name.Contains(clone)) {
            prefabName = name.Substring(0, name.Length - clone.Length);
            name = prefabName + getVariableInstanceID(gameObject);
        }

        WriteAdd($"CreateGameObject(\"{name}\",\"{prefabName}\")");

        if (transform.parent) {
            DeclareAndFind(transform.parent.gameObject);
            WriteGet().Append($".transform.parent = ");
            WriteGet(transform.parent.gameObject).AppendLine(".transform;");
        }
    }

    void OnDestroy() {
        if (output == null) return;
        WriteRemove();
    }

}
