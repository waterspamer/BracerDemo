using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureText : Capture {

    private string _previousText;
    private Text Text;

    protected override void Awake() {
        base.Awake();
        Text = GetComponent<Text>();
    }

    protected override void OnFrame() {

        DeclareAndFind(gameObject);
        if (_previousText != Text.text) {
            _previousText = Text.text;
            WriteGet().AppendLine($".GetComponent<UnityEngine.UI.Text>().text = \"{Text.text}\";");
        }

    }

}
