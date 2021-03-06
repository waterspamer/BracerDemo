using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor.Timeline;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


public struct ReplaySettings {
    public ReplayBase ReplayBase;
    //public ReplayBaseBig ReplayBaseBig;
    public bool Enabled;
    public int FramesOffset;
    public bool IsBig;
}

public class ReplayWindow : EditorWindow {

    public Dictionary<string, ReplaySettings> _replaySettingsDictionary = new Dictionary<string, ReplaySettings>();
    public string BaseScenePath = "";

    public static int ReplayPosition = 0;

    public static int VideoStartPosition = 0;
    public static int VideoEndPosition = 1;

    public static Camera RenderCamera;
    public static string RenderCameraPath;

    private bool ReplayMode {
        get { return !string.IsNullOrEmpty(BaseScenePath); }
    }

    //private List<string> ReplayNames = new List<string>();

    private string pathToReplayScene {
        get {
            return "Assets/Replay.unity";
        }
    }
    /*
    private string pathToReplaySceneAbsolute {
        get {
            return Application.dataPath + "/Replay.unity";
        }
    }
    */

    [MenuItem("Window/Replay")]
    public static void ShowWindow() {
        var window = EditorWindow.GetWindow(typeof(ReplayWindow));
        //window.maxSize = new Vector2(300, 220);
        window.minSize = new Vector2(0,50);
        window.titleContent = new GUIContent("Replay");

        EditorApplication.playModeStateChanged += WhenPlayModeStateChanged;
    }

    private static void WhenPlayModeStateChanged(PlayModeStateChange state) {
        if (state == PlayModeStateChange.EnteredPlayMode) {
            //EditorApplication.isPaused = true;
            /*
            ReplayWindow replayWindow = FindObjectOfType<ReplayWindow>();
            replayWindow.ExitReplayMode();
            Debug.Log("replayWindow.ExitReplayMode();");
            */
        }
    }

    private int _maxFramesCount;


    private void Reset(int newReplayPosition) {
        EditorSceneManager.OpenScene(pathToReplayScene);
        
        // Создаем новые инстансы классов ReplayBase
        for (int i = _replaySettingsDictionary.Count - 1; i >= 0; i--) {
            var entry = _replaySettingsDictionary.ElementAt(i);
            ReplaySettings replaySettings = entry.Value;
            if (!replaySettings.IsBig) {
                replaySettings.ReplayBase = CreateReplay(entry.Key);
            }
            else {

                //ReplayPCX newReplayFromDll = new ReplayPCX();
                //replaySettings.ReplayBase = newReplayFromDll;
                
            }

            _replaySettingsDictionary[entry.Key] = replaySettings;
        }




        Animator[] animators = FindObjectsOfType<Animator>();
        foreach (var an in animators) {
            if (Animator && an != Animator) {
                an.Update(0f);
            }
        }

        //ReplayPosition = 0;
        Move(newReplayPosition);

        // update scene
        EditorUtility.SetDirty(this);
    }


    public delegate void MultiDelegate(int num);
    public static MultiDelegate myMultiDelegate;


    private void Move(int newReplayPosition) {

        if (!Animator) {
            if (!string.IsNullOrEmpty(AnimatorPath)) {
                var animatorGameObject = GameObject.Find(AnimatorPath);
                var animator = animatorGameObject?.GetComponent<Animator>();
                if (animator) {
                    Animator = animator;
                }
            }
        }

        if (Animator) {
            UnityEngine.Object[] selectedObjects = new UnityEngine.Object[1];
            selectedObjects[0] = Animator.gameObject;
            Selection.objects = selectedObjects;
        }

        if (myMultiDelegate != null){
            myMultiDelegate(newReplayPosition);
        }

        //Debug.Log("_replaySettingsDictionary.Count =    " + _replaySettingsDictionary.Count);
        foreach (KeyValuePair<string, ReplaySettings> entry in _replaySettingsDictionary) {
            if (entry.Value.Enabled) {
                if (!entry.Value.IsBig) {
                    //Debug.Log("entry.Value.ReplayBase.MoveTo");
                    entry.Value.ReplayBase.MoveTo(newReplayPosition + entry.Value.FramesOffset);
                }
                // .dll
                if (entry.Value.IsBig) {
                    Debug.Log("DLL MoveTo");
                    entry.Value.ReplayBase.MoveTo(newReplayPosition + entry.Value.FramesOffset);
                }
            }
        }

        ReplayPosition = newReplayPosition;

        ReplaySubject[] replaySubjects = FindObjectsOfType<ReplaySubject>();
        foreach (var subject in replaySubjects) {
            subject.OnMove(newReplayPosition);
        }

        AnimationWindowHelper.SetCurrentFrame(newReplayPosition);
        
    }

    private ReplayBase CreateReplay(string replayName) {
        var types = typeof(ReplayBase).Assembly.GetTypes();
        var replayType = types.Where(x => x.Name == replayName).FirstOrDefault();
        if (replayType == null) return null;
        if (!replayType.IsSubclassOf(typeof(ReplayBase))) return null;
        return (ReplayBase)Activator.CreateInstance(replayType);
    }

    
    public void ExitReplayMode() {
        EditorSceneManager.OpenScene(BaseScenePath);
        FileUtil.DeleteFileOrDirectory(pathToReplayScene);
        BaseScenePath = "";
        AssetDatabase.Refresh();
        ReplayPosition = 0;
        EditorApplication.update -= RenderFrame; // <---------------------
    }

    //private List<bool> _replayEnablesList = new List<bool>();
    //private string[] _replayNamesArray;
    //private List<int> _replayOffsetsList = new List<int>();

    Vector2 scrollPosition;
    private const int _sideMenuWidth = 180;

    public ReplayBase ReplayBase;
    private DefaultAsset targetFolder = null;


    void OnGUI() {

        if (ReplayMode) {
            Texture2D tex = new Texture2D(1, 1, TextureFormat.RGBA32, false);
            tex.SetPixel(0, 0, new Color32(55, 55, 55, 255));
            
            tex.Apply();
            GUI.DrawTexture(new Rect(0, 0, maxSize.x, maxSize.y), tex, ScaleMode.StretchToFill);
        }


        // Добавление в словарь файлов реплей
        var replayNames = typeof(ReplayBase).Assembly.GetTypes()
            .Where(x => x.IsSubclassOf(typeof(ReplayBase)))
            .Select(x => x.FullName);
        string[] _replayNamesArray = replayNames.ToArray();

        
        // ---------------------------------------------------------------------------------------------------------------
        for (int i = 0; i < _replayNamesArray.Length; i++) {
            if (!_replaySettingsDictionary.ContainsKey(_replayNamesArray[i])) {
                ReplaySettings replaySettings = new ReplaySettings();
                replaySettings.ReplayBase = CreateReplay(_replayNamesArray[i]);
                _replaySettingsDictionary.Add(_replayNamesArray[i], replaySettings);
            }
        }
        
        /*
        // Добавляем реплей из .dll
        if (!_replaySettingsDictionary.ContainsKey("ReplayPCX")) {
            ReplaySettings replaySettingsDll = new ReplaySettings();
            //ReplayPCX newReplayFromDll = new ReplayPCX();
            //replaySettingsDll.ReplayBase = newReplayFromDll;
            replaySettingsDll.IsBig = true;
            _replaySettingsDictionary.Add("ReplayPCX", replaySettingsDll);
        }
        */
        
        
        //
        // -------------------------------------------------------------------------------------------------------------
        
        EditorGUILayout.BeginHorizontal();

        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(_sideMenuWidth + 50), GUILayout.Height(position.height)); // , GUILayout.Height(position.height)

        EditorGUI.BeginChangeCheck();

        _maxFramesCount = 0;
        
        // изменение параметров реплея (оффсет и энейбл)
        for (int i = _replaySettingsDictionary.Count - 1; i >= 0; i--) {
            var entry = _replaySettingsDictionary.ElementAt(i);
            ReplaySettings replaySettings = entry.Value;
            GUILayout.BeginHorizontal();

            replaySettings.Enabled = EditorGUILayout.Toggle(entry.Key, replaySettings.Enabled, GUILayout.Width(_sideMenuWidth));
            replaySettings.FramesOffset = EditorGUILayout.IntField("", replaySettings.FramesOffset, GUILayout.Width(50));
            
            
            if (replaySettings.Enabled) {
                if (!replaySettings.IsBig) {
                    if (replaySettings.ReplayBase.FrameCount > _maxFramesCount) {
                        _maxFramesCount = replaySettings.ReplayBase.FrameCount + replaySettings.FramesOffset; // Максимальная длительность композиции
                    }
                } else {
                    // .dll
                    if (replaySettings.ReplayBase.FrameCount > _maxFramesCount) {
                        _maxFramesCount = replaySettings.ReplayBase.FrameCount + replaySettings.FramesOffset; // Максимальная длительность композиции
                    }
                }
            }
            
            //_maxFramesCount = 2000;

            _replaySettingsDictionary[entry.Key] = replaySettings;
            GUILayout.EndHorizontal();
        }

        if (EditorGUI.EndChangeCheck()) {
            if (ReplayMode) {
                Reset(ReplayPosition);
            }
        }

        GUIStyle replayModeStyle = new GUIStyle(GUI.skin.button);
        replayModeStyle.normal.textColor = Color.white;        

        GUILayout.EndScrollView();

        EditorGUILayout.BeginVertical(GUILayout.Width(position.width - _sideMenuWidth - 100));

        if (!ReplayMode) {
            if (GUILayout.Button("Enter replay mode", GUILayout.MinWidth(40), GUILayout.MaxWidth(120))) {
                EnterReplayMode(); // <--------------- replayNames.ToArray()[selectedReplay]
            }
        } else {
            GUI.backgroundColor = new Color32(159,68,68,255);

            if (GUILayout.Button("Exit replay mode", replayModeStyle, GUILayout.MinWidth(40), GUILayout.MaxWidth(120))) {
                ExitReplayMode();
            }
            GUI.backgroundColor = Color.white;
            //GUI.contentColor = Color.black;
        }
        
        //}
        
        if (ReplayMode) {

            int newReplayPosition = Mathf.RoundToInt(GUILayout.HorizontalSlider((float)ReplayPosition, 0, _maxFramesCount)); // Replay.FrameCount  // , GUILayout.Width(500)

            if (newReplayPosition < ReplayPosition) {
                Reset(newReplayPosition);
            } else if (newReplayPosition > ReplayPosition) {
                //Debug.Log(newReplayPosition +  " - "  +  ReplayPosition);
                Move(newReplayPosition);
            }
            

            EditorGUILayout.LabelField(ReplayPosition + "/" + _maxFramesCount); // Replay.FrameCount

            float videoStartPositionF = VideoStartPosition;
            float videoEndPositionF = VideoEndPosition;

            EditorGUILayout.MinMaxSlider(ref videoStartPositionF, ref videoEndPositionF, 0, _maxFramesCount); // Replay.FrameCount
            VideoStartPosition = Mathf.RoundToInt(videoStartPositionF);
            VideoEndPosition = Mathf.RoundToInt(videoEndPositionF);
            
            EditorGUILayout.BeginHorizontal();
            
            if (GUILayout.Button("Previous Frame", GUILayout.MinWidth(40), GUILayout.MaxWidth(120))) {
                Reset(ReplayPosition - 1);
            }

            if (GUILayout.Button("Next Frame", GUILayout.MinWidth(40), GUILayout.MaxWidth(120))) {
                Move(ReplayPosition + 1);
            }

            if (GUILayout.Button("To Start", GUILayout.MinWidth(40), GUILayout.MaxWidth(120))) {
                Reset(0);
            }

            if (GUILayout.Button("PLAY", GUILayout.MinWidth(40), GUILayout.MaxWidth(80))) {
                    EditorApplication.update -= PlayFrame;
                    EditorApplication.update += PlayFrame;
                
            }

            if (GUILayout.Button("STOP", GUILayout.MinWidth(40), GUILayout.MaxWidth(80))) {
                EditorApplication.update -= PlayFrame;
            }

            if (GUILayout.Button("Render Range", GUILayout.MinWidth(40), GUILayout.MaxWidth(120))) {
                if (RenderCamera) {
                    Reset(VideoStartPosition);
                    EditorApplication.update -= RenderFrame;
                    EditorApplication.update += RenderFrame;
                }
            }
            
            if (!RenderCamera) {
                if (!string.IsNullOrEmpty(RenderCameraPath)) {
                    var cameraGameObject = GameObject.Find(RenderCameraPath);
                    var camera = cameraGameObject?.GetComponent<Camera>();
                    if (camera) {
                        RenderCamera = camera;
                    }
                }
            }
            
            EditorGUILayout.EndHorizontal();
            
            RenderCamera = (Camera)EditorGUILayout.ObjectField("Camera", RenderCamera, typeof(Camera), true, GUILayout.MinWidth(40), GUILayout.MaxWidth(300));
            if (RenderCamera) {
                RenderCameraPath = Capture.GetGameobjectPath(RenderCamera.gameObject);
            } else {
                RenderCameraPath = null;
            }

            

            Animator = (Animator)EditorGUILayout.ObjectField("Animator", Animator, typeof(Animator), true, GUILayout.MinWidth(40), GUILayout.MaxWidth(300));

            if (Animator) {
                AnimatorPath = Capture.GetGameobjectPath(Animator.gameObject);
            } else {
                AnimatorPath = null;
            }

        }

        EditorGUILayout.EndHorizontal();
    }

    public static Animator Animator;
    public string AnimatorPath;

    void RenderFrame() {
        //Debug.Log("RenderFrame " + ReplayPosition);
        if (ReplayPosition < VideoEndPosition) {


            //RenderTexture renderTexture = new RenderTexture(1920,1080,1);
            //renderTexture.antiAliasing = 8;
            
            Screenshots.SaveCameraShot( 
                RenderCamera,
                (RenderTexture)Resources.Load("RT", typeof(RenderTexture)),
                (Material)Resources.Load("DivideByAlpha", typeof(Material)),
                ReplayPosition.ToString()
                );

            Move(ReplayPosition + 1);
        }
        else {
            EditorApplication.update -= RenderFrame;
        }
    }

    void PlayFrame() {
        //Debug.Log("PlayFrame " + ReplayPosition);
        if (ReplayPosition < VideoEndPosition) {
            //Screenshots.SaveCameraShot(RenderCamera, ReplayPosition.ToString());
            Move(ReplayPosition + 1);
        } else {
            EditorApplication.update -= RenderFrame;
        }
    }





    void EnterReplayMode() {  //string replayName

        titleContent = new GUIContent("Replay: ");  // + replayName
        //ReplayName = replayName;

        EditorSceneManager.SaveScene(SceneManager.GetActiveScene());
        Scene currentScene = SceneManager.GetActiveScene();
        BaseScenePath = currentScene.path;

        FileUtil.CopyFileOrDirectory(BaseScenePath, pathToReplayScene);
        AssetDatabase.Refresh();

        EditorSceneManager.OpenScene(pathToReplayScene);

        // FillReplaySettingsList();

        Reset(0); // <----------------------------------

    }



    void OnDestroy() {
        Debug.Log("Script was destroyed");
    }


    public static void Resize<T>(List<T> list, int sz, T c) {
        int cur = list.Count;
        if (sz < cur)
            list.RemoveRange(sz, cur - sz);
        else if (sz > cur) {
            if (sz > list.Capacity)//this bit is purely an optimisation, to avoid multiple automatic capacity changes.
                list.Capacity = sz;
            list.AddRange(Enumerable.Repeat(c, sz - cur));
        }
    }
    public static void Resize<T>(List<T> list, int sz) where T : new() {
        Resize(list, sz, new T());
    }
    
}
