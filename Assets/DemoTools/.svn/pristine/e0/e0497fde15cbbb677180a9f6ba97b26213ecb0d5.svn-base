using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureUnpackPrefab : Capture {

    private bool _doneFlag;
    protected override void OnFrame() {
        if (!_doneFlag) {
            _doneFlag = true;
            DeclareAndFind(gameObject);
            output.AppendLine($"UnityEditor.PrefabUtility.UnpackPrefabInstance( {GetGet(gameObject)} , UnityEditor.PrefabUnpackMode.Completely, UnityEditor.InteractionMode.AutomatedAction);");
        }
        
    }
    
}
