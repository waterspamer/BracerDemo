using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CaptureGameObjectEnabled : Capture
{
    private bool _previousFrameEnabled;

    protected override void Awake()
    {
        base.Awake();
        _previousFrameEnabled = gameObject.activeSelf;
    }
    
    private static string BoolToString(bool value)
    {
        return value.ToString().ToLower();
    }

    protected override void OnFrame()
    {
        //Debug.Log("");
        DeclareAndFind(gameObject);
        //if (gameObject.activeSelf != _previousFrameEnabled)
        {
            WriteGet().AppendLine($".SetActive({BoolToString(gameObject.activeSelf)});");
            _previousFrameEnabled = !enabled;
        }
    }
}
