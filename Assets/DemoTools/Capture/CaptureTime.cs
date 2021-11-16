using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureTime : Capture {

    public List<float> TimeList;
    public Text TimeText;



    protected override void OnFrame() {

        DeclareAndFind(gameObject);

        TimeText.text = Time.unscaledDeltaTime.ToString("0.0000");
        
        output.AppendLine($"{GetGet(gameObject)}.GetComponent<CaptureTime>().TimeList.Add({Time.unscaledTime}f);");
        output.AppendLine($"{GetGet(gameObject)}.GetComponent<CaptureTime>().UpdateTextWithLastTimeInArray();");
    }

    public void UpdateTextWithLastTimeInArray() {
        TimeText.text = TimeList[TimeList.Count - 1].ToString("0.000");
    }



}
