using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureDeclare : Capture {

    public GameObject[] GameObjectToDeclare;

    void Start() {
        foreach (GameObject obj in GameObjectToDeclare) {
            bool wasActive = obj.activeSelf;
            //obj.GetComponent<CaptureSetActive>().Enabled = false;
            obj.SetActive(true);
            DeclareAndFind(obj);
            obj.SetActive(wasActive);
            //obj.GetComponent<CaptureSetActive>().Enabled = true;
        }
    }
    

}
