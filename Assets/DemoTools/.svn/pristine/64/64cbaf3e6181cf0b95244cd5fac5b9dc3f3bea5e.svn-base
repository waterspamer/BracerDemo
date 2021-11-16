using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

[ExecuteAlways]
public class VideoPlayerControl : ReplaySubject {

    public VideoPlayer VideoPlayer;
    public float ScaleMultiplier = 1f;

    public int FramesOffset;

    public override void OnMove(int frame) {
        base.OnMove(frame);
        VideoPlayer = GetComponent<VideoPlayer>();
        if (!VideoPlayer.isPrepared) {
            VideoPlayer.Prepare();
        }
        VideoPlayer.Play();
        //VideoPlayer.StepForward();
        VideoPlayer.time = (frame + FramesOffset) * Time.fixedDeltaTime;
    }

    void Update() {
        float aspectRatio = (float)VideoPlayer.width / VideoPlayer.height;
        transform.localScale = new Vector3(ScaleMultiplier * aspectRatio, ScaleMultiplier, 1f);
    }

}

