using System;
using System.Linq;
using UnityEngine;
using UnityEditor;
using System.Reflection;


[CustomEditor(typeof(CaptureProperties))]
public class CapturePropertiesEditor : Editor {

    public override void OnInspectorGUI() {

        // DrawDefaultInspector();
        
        CaptureProperties captureProperties = (CaptureProperties)target;


        captureProperties.CaptureLayer = EditorGUILayout.IntField("CaptureLayer", captureProperties.CaptureLayer);


        var properties = captureProperties.ComponentMembers==null
            ?new System.Collections.Generic.List<CaptureProperties.ComponentMember>()
            :captureProperties.ComponentMembers.ToList();

        properties.Add(new CaptureProperties.ComponentMember());
        var propertiesArray = properties.ToArray();


        var components = captureProperties.GetComponents<Component>();
        var componentsNames = components.Select(x => x.GetType().Name).ToList();
        componentsNames.Add("None");
        var componentsTypes = components.Select(x => x.GetType()).ToList();


        for (int i=0; i< propertiesArray.Length; i++) {
            int selected = componentsTypes.Count;
            for (int j = 0; j < componentsTypes.Count; j++) {
                if (componentsTypes[j].FullName == propertiesArray[i].componentTypeFullName) {
                    selected = j;
                    break;
                }
            }
            //EditorGUILayout.GetControlRect()
            
            EditorGUILayout.BeginHorizontal();
            selected = EditorGUILayout.Popup("", selected, componentsNames.ToArray(), GUILayout.MinWidth(32));

            if (selected < componentsTypes.Count) {
                var componentType = componentsTypes[selected];
                propertiesArray[i].componentTypeFullName = componentType.FullName;

                var members = 
                    componentType.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                    .Where(x=>CaptureProperties.MemberSupported(x)).ToArray();

                var membersNames = members.Select(x => x.Name).ToArray();

                int selectedProperty = 0;
                for (int m = 0; m < membersNames.Length; m++) {
                    if (membersNames[m] == propertiesArray[i].memberName) {
                        selectedProperty = m;
                        break;
                    }
                }
                
                selectedProperty = EditorGUILayout.Popup("", selectedProperty, membersNames);
                propertiesArray[i].memberName = membersNames[selectedProperty];
            }
            else {
                propertiesArray[i].componentTypeFullName = null;
            }
            EditorGUILayout.EndHorizontal();
        }

        captureProperties.ComponentMembers = propertiesArray.Where(x => x.componentTypeFullName != null).ToArray();


        


    }

}