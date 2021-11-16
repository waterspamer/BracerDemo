using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Timeline = FloatArrayIterator<ReplayFrame>;

public class ReplayController : MonoBehaviour {

    public enum ReplayAction { None, Record, Play }

    [Header("Common")]
    public ReplayAction ActionOnAwake = ReplayAction.None;
    public string ReplayName;
    public ReplayTarget Target;

    [Header("Record Options")]
    public bool RecordMovement = true;
    [Range(10, 60)]
    public int RecordMovementFPS = 25;
    

    [Header("Play Options")]
    [Tooltip("Offset in seconds")]
    public float PlayOffset = 0f;

    public bool IsRecording { get { return _currentKeyFrames != null; } }
    public bool IsPlaying { get { return _replay != null; } }
    public float ReplayTime { get { return Time.realtimeSinceStartup - _replayStartTime; } }

    private List<Timeline.Entry> _currentKeyFrames;
    private Timeline _replay;
    private float _replayStartTime = 0f;
    private float _lastMoveRecordTime = 0f;
    private float _movementDiscretization = 1f / 25f;

    private void OnValidate() {
        if (string.IsNullOrEmpty(ReplayName)) {
            ReplayName = gameObject.name.Replace(" ", "_");
        }
    }

    private void Awake() {
        _movementDiscretization = 1f / (float)RecordMovementFPS;

        if (ActionOnAwake == ReplayAction.Play){
            Play();
        } else if (ActionOnAwake == ReplayAction.Record) {
            StartRecording();
        }
    }

    private void OnDestroy() {
        Stop();
    }

    public void StartRecording() {
        if (!IsRecording && !IsPlaying && Target != null) {
            int capacity = 4 * 60 * RecordMovementFPS;
            _currentKeyFrames = new List<Timeline.Entry>(capacity);
            _lastMoveRecordTime = 0f;
            _replayStartTime = Time.realtimeSinceStartup;

            RecordInitialState();
            Target.ActiveStateChangeEvent += OnActiveStateChangeEvent;
        }
    }

    private void StopRecording() {
        if (IsRecording) {
            Target.ActiveStateChangeEvent -= OnActiveStateChangeEvent;

            var result = _currentKeyFrames.ToArray();
            _currentKeyFrames = null;

            ReplayFile.Save(ReplayName, result);
        }
    }

    public void Stop() {
        if (IsRecording) {
            StopRecording();
        } else if (IsPlaying) {
            StopPlaying();
        }     
    }

    public void Play() {
        if (!IsRecording && !IsPlaying && Target != null) {
            var data = ReplayFile.Load(ReplayName);

            if (data != null && data.Length > 0) {
                _replay = new Timeline();
                _replay.Set(data);
                _replayStartTime = Time.realtimeSinceStartup;
            }
        }
    }

    private void StopPlaying() {
        if (IsPlaying) {
            _replay = null;
        }
    }

    private void RecordInitialState() {
        SaveFrame(Target.gameObject.activeSelf ? ReplayFrameAction.EnableGameObject : ReplayFrameAction.DisableGameObject);
    }

    private void OnActiveStateChangeEvent(ReplayTarget target, bool active) {
        SaveFrame(active ? ReplayFrameAction.EnableGameObject : ReplayFrameAction.DisableGameObject);
    }

    private void SaveFrame(ReplayFrameAction action) {
        if (IsRecording && action != ReplayFrameAction.None && Target != null) {
            var entry = new Timeline.Entry(ReplayTime, new ReplayFrame(Target.transform.position, Target.transform.rotation, action));
            _currentKeyFrames.Add(entry);
        }
    }

    private void ApplyFrame(ReplayFrame frame) {
        switch (frame.Action) {
            case ReplayFrameAction.Move:
                Target.Move(frame.Position, frame.Rotation);
                break;

            case ReplayFrameAction.EnableGameObject:
                Target.gameObject.SetActive(true);
                break;

            case ReplayFrameAction.DisableGameObject:
                Target.gameObject.SetActive(false);
                break;
        }
    }

    private void LateUpdate() {
        var replayTime = ReplayTime;

        if (IsRecording) {
            var delta = replayTime - _lastMoveRecordTime;

            if (RecordMovement) {
                if (delta >= _movementDiscretization && (Target.PositionHasChanged() || Target.RotationHasChanged())) {
                    SaveFrame(ReplayFrameAction.Move);
                    _lastMoveRecordTime = replayTime;
                }
            }
        } else if (IsPlaying) {
            ReplayFrame frame;

            while (_replay.Next(replayTime + PlayOffset, out frame)) {
                ApplyFrame(frame);
            }
        }
    }
}
