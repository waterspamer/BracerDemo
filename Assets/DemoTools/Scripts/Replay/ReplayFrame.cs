using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ReplayFrameAction {
    None,
    Move,
    EnableGameObject,
    DisableGameObject
}

[Serializable]
public class ReplayFrame {
    public Vector3 Position;
    public Quaternion Rotation;
    public ReplayFrameAction Action;

    public ReplayFrame(Vector3 position, Quaternion rotation, ReplayFrameAction action) {
        Position = position;
        Rotation = rotation;
        Action = action;
    }
}
