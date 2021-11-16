using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class AnimationWindowHelper {
    
    static System.Type animationWindowType = null;
    static System.Type GetAnimationWindowType() {
        if (animationWindowType == null) {
            animationWindowType = System.Type.GetType("UnityEditor.AnimationWindow, UnityEditor");
        }
        return animationWindowType;
    }

    static UnityEngine.Object GetOpenAnimationWindow() {
        UnityEngine.Object[] openAnimationWindows = Resources.FindObjectsOfTypeAll(GetAnimationWindowType());
        if (openAnimationWindows.Length > 0) {
            return openAnimationWindows[0];
        }
        return null;
    }

    //
    public static void TestPrintMethods() {

        UnityEngine.Object w = GetOpenAnimationWindow();

        if (w != null) {
            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
            FieldInfo animEditorFieldInfo = GetAnimationWindowType().GetField("m_AnimEditor", flags);

            Type animEditorType = animEditorFieldInfo.FieldType;
            System.Object animEditorObject = animEditorFieldInfo.GetValue(w);

            MethodInfo[] methods = animEditorType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            Debug.Log("Methods : " + methods.Length);

            methods[0].Invoke(animEditorObject, new object[0] { });  //BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.NonPublic,

            for (int i = 0; i < methods.Length; i++) {
                MethodInfo currentInfo = methods[i];
                Debug.Log(currentInfo.ToString() + "   "  + currentInfo.MethodImplementationFlags);
            }

            //animEditorType.InvokeMember("BeginKeyModification", BindingFlags.InvokeMethod | BindingFlags.Public, null, null, new object[0] { }); // new object[1] { true }
        }

    }

    public static void PrintMethods() {

        UnityEngine.Object w = GetOpenAnimationWindow();  // Объект типа UnityEditor.AnimationWindow

        Debug.Log(w.GetType());
        Debug.Log(w);
        
        if (w != null) {

            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
            FieldInfo animEditorFieldInfo = GetAnimationWindowType().GetField("m_AnimEditor", flags);

            Type animEditorType = animEditorFieldInfo.FieldType;
            System.Object animEditorObject = animEditorFieldInfo.GetValue(w);

            //Debug.Log(animEditorObject.GetType() + "---------------------------------");

            FieldInfo animWindowState = animEditorType.GetField("m_State", flags);
            Type windowStateType = animWindowState.FieldType;
            System.Object windowStateTypeObject = animWindowState.GetValue(animEditorObject);

            MethodInfo[] methods = windowStateType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            Debug.Log("Methods : " + methods.Length);
            for (int i = 0; i < methods.Length; i++) {
                MethodInfo currentInfo = methods[i];
                Debug.Log(i + "   " + currentInfo.ToString());
            }

        }
    }



    public static void SetCurrentFrame(int frame) {

        UnityEngine.Object w = GetOpenAnimationWindow();  // Объект типа UnityEditor.AnimationWindow

        if (w != null) {

            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
            FieldInfo animEditorFieldInfo = GetAnimationWindowType().GetField("m_AnimEditor", flags);

            Type animEditorType = animEditorFieldInfo.FieldType;
            System.Object animEditorObject = animEditorFieldInfo.GetValue(w);

            FieldInfo animWindowState = animEditorType.GetField("m_State", flags);
            Type windowStateType = animWindowState.FieldType;
            System.Object windowStateTypeObject = animWindowState.GetValue(animEditorObject);

            MethodInfo[] methods = windowStateType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            
            MethodInfo methodInfo = methods.FirstOrDefault(x => x.Name == "set_currentFrame");
            methodInfo.Invoke(windowStateTypeObject, new object[1] { frame });


            // Это нужно чтоб окно обновилось
            MethodInfo methodInfo4 = methods.FirstOrDefault(x => x.Name == "StopPreview");
            methodInfo4.Invoke(windowStateTypeObject, new object[0] { });


            MethodInfo methodInfo3 = methods.FirstOrDefault(x => x.Name == "SetDirty");
            methodInfo3.Invoke(windowStateTypeObject, new object[0] { });

            MethodInfo methodInfo2 = methods.FirstOrDefault(x => x.Name == "ForceRefresh");
            methodInfo2.Invoke(windowStateTypeObject, new object[0] { });
        }
    }
    
}

/*
public class AnimationWindow : MonoBehaviour {
    
    public InspectorButton _PrintMethods;
    public InspectorButton _TestPrintMethods;
    
    public void TestPrintMethods() {
        wAnimationWindowHelper.TestPrintMethods();
    }

    public void PrintMethods() {
        wAnimationWindowHelper.PrintMethods();  
    }
    
}
*/
