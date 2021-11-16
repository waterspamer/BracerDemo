using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSetActive : Capture {

    //[HideInInspector]
    //public bool Enabled;
    
    public bool DeactivateOnStart;

    // так себе код. это чтобы записываеть объекты, которые при старте должны быть выключены
    // можно попробовать использовать тут FindObjectAll чтобы искать среди скрытых объектов
    protected override void Awake() {
        base.Awake();

        if (DeactivateOnStart) {
            gameObject.SetActive(false);
        }
    }

    void OnDisable() {
        //if (!Enabled) return;
        if (!state.captureSettings.Enable) return;
        DeclareAndFind(gameObject);
        WriteGet().AppendLine(".SetActive(false);");
    }

    protected override void OnEnable() {
        //if (!Enabled) return;
        if (!state.captureSettings.Enable) return;
        DeclareAndFind(gameObject);
        WriteGet().AppendLine(".SetActive(true);");
    }

}
