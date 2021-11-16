using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;


[CustomEditor(typeof(CaptureAnimator))]
public class CaptureAnimatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        //base.OnInspectorGUI();
        if (GUILayout.Button("Get Animator States"))
        {
            var tmp = (target as CaptureAnimator).gameObject.GetComponent<Animator>();
            UnityEditor.Animations.AnimatorController ac = tmp.runtimeAnimatorController as UnityEditor.Animations.AnimatorController;
         
            // Number of layers:
            int layerCount = ac.layers.Length;
            //Debug.Log(string.Format("Layer Count: {0}", layerCount));
            (target as CaptureAnimator).AnimatorStateNames = new List<string>();
            // Names of each layer:
            for (int layer = 0; layer < layerCount; layer++) {
                //Debug.Log(string.Format("Layer {0}: {1}", layer, ac.layers[layer].name));
                foreach (var state in ac.layers[layer].stateMachine.states)
                {
                    (target as CaptureAnimator).AnimatorStateNames.Add(state.state.name);
                }
            }

            //var asset = AssetDatabase.F (target as GameObject).GetComponent<Animator>();
            //var anim = (target as GameObject)?.GetComponent<Animator>().runtimeAnimatorController as AnimatorController;
            //foreach (var childAnimatorState in controller.layers[0].stateMachine.states)
                {
              //      Debug.Log("asdas");
                //    (target as GameObject)?.GetComponent<CaptureAnimator>().AnimatorStateNames.Add(childAnimatorState.ToString());
                }
        }
        
    }

}
