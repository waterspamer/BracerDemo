using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureParticles : Capture {

    void Start() {
        DeclareAndFind(gameObject);
        if (GetComponent<ParticleSystem>().main.playOnAwake) {
            WriteGet().AppendLine($".GetComponent<ParticleSystem>().Pause();");
        }
    }


    private bool _isPlaying;
    private bool _isPaused;

    protected override void Awake()
    {
        base.Awake();
        _isPlaying = GetComponent<ParticleSystem>().isPlaying;
        _isPaused = GetComponent<ParticleSystem>().isPaused;

    }

    private float _playBackTime = 0f;

    // Update is called once per frame
    void Update(){
        //GetComponent<ParticleSystem>().Pause();
        //Debug.Log(GetComponent<ParticleSystem>().isPaused + " " + GetComponent<ParticleSystem>().isPlaying);
        if (GetComponent<ParticleSystem>().isPlaying)
        {

            WriteGet().AppendLine($".GetComponent<ParticleSystem>().Play();");

            WriteGet().AppendLine($".GetComponent<ParticleSystem>().Simulate({Time.deltaTime}f,true,false);");
            
        }
        else
            WriteGet().AppendLine($".GetComponent<ParticleSystem>().Stop();");
            //WriteGet().AppendLine($".GetComponent<ParticleSystem>().Simulate({(GetComponent<ParticleSystem>().isPlaying? getFrameTime() : 0)}f,true,false);");

        {
            _playBackTime = 0f;
            //WriteGet().AppendLine($".GetComponent<ParticleSystem>().time = 0f;");

        }
        
    }
}
