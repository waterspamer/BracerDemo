using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureEnable : Capture {

    public Behaviour Behaviour;
    //public Component Behaviour;
    private bool _enabled;

    private static string BoolToString(bool value)
    {
        return value.ToString().ToLower();
    }

    protected override void OnFrame()
    {

        DeclareAndFind(gameObject);
        if (Behaviour.enabled != _enabled)
        {
            WriteGet().AppendLine($".GetComponent<{typeof(Behaviour)}>().enabled = {BoolToString(Behaviour.enabled)};");
            _enabled = !enabled;
        }
    }
}
