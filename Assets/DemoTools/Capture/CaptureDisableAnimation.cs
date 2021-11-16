using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureDisableAnimation : Capture {

    private bool _doneFlag;
    protected override void OnFrame() {

        if (!_doneFlag) {
            _doneFlag = true;
            DeclareAndFind(gameObject);
            
            output.Append($"DestroyImmediate({GetGet(gameObject)}.GetComponent<Animator>());");
        }
    }

}
