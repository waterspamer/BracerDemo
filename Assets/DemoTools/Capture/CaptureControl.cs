using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaptureControl : MonoBehaviour {
    
    public void StartCapture() {
        Capture.StartCapture();
    }
    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("Escape");
            StopCaptureAndRestart();
        }
    }

    public void StopCaptureAndRestart() {
        //Debug.Log(Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad > 3) {
            Capture.StopCapture();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void StopCaptureAndExit() {
        //Debug.Log(Time.timeSinceLevelLoad);
        if (Time.timeSinceLevelLoad > 3f) {
            Capture.StopCapture();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }

}
