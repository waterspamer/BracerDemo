using System.Collections.Generic;
using UnityEditor;
using System.Text;
using UnityEngine;
using System.Reflection;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Debug = UnityEngine.Debug;


public class Capture : MonoBehaviour {

    public int CaptureLayer;

    public class State {
        public string replayClassName;
        public int frame;
        public HashSet<GameObject> declaredGameObjects = new HashSet<GameObject>();
        public bool needFrameFinalization = false;
        public CaptureSettings captureSettings;
    }

    protected static State state; // private

    private static string NameForPc = "ReplayPC";
    private static string NameForAndroid = "ReplayApk";

    private static string DefaultName() {
#if UNITY_EDITOR
        return NameForPc;
#else
        return NameForAndroid;
#endif
    }

    public static string FindUniqueName() {

        //var typesNames = typeof(ReplayBase).Assembly.GetTypes().Select(x=>x.FullName);

#if UNITY_EDITOR
        var path = GetReplayProjectPath(""); // "Replay.cs" // NameForPc + ".cs"
#else
        var path = GetReplayExternalPath(""); // NameForAndroid + ".cs"
#endif

        var directory = Path.GetDirectoryName(path);
        if (!Directory.Exists(directory)) {
            Directory.CreateDirectory(directory);
        }

        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        var fileInfo = directoryInfo.GetFiles();
        var fileNames = fileInfo.Select(x => x.Name);

        int i = 0;
        while (true) {
            var name = DefaultName() + i;
            if (!fileNames.Contains(name + ".cs")) {
                return name;
            }
            i++;
        }
        
        /*
        var typesNames = typeof(ReplayBase).Assembly.GetTypes().Select(x => x.FullName);
        int i = 0;
        while (true) {
            var name = "Replay" + i;
            if (!typesNames.Contains(name)) {
                return name;
            }
            i++;
        }
        */
    }
    

    public static float getFrameTime() {
        return 0.1f;
    }

    protected static StringBuilder output;


    //static Capture() {
    //state.frame = 0;
    //Initialize();
    //}

    //public static bool CaptureStarted;

    void OnApplicationQuit() {
        StopCapture();
    }

    public static void StopCapture() {
        if (output == null) return;
        Deinitialize();
        output = null;

        state = null;
    }


    public static void StartCapture() { // StartCapture
        if (state == null) {
            Initialize();
        }
    }

    protected virtual void Awake() {
        //if (!state.captureSettings.Enable) return;
        StartCapture();
    }

    // перемещаем в OnEnable()
    //void Start() {
        // StartCapture(); // < -----------------------------------------------------------------------
        // StartCoroutine(LateFixedUpdate());
    //}

    protected virtual void OnEnable() {
        StartCoroutine(LateFixedUpdate());
    }


    private static void Initialize() {

        Debug.Log( "Initialize" );

        state = new State();
        state.frame = 0;
        state.captureSettings = Resources.Load<CaptureSettings>("CaptureSettings");

        if (state.captureSettings == null) {
            state.captureSettings = new CaptureSettings();
            state.captureSettings.CaptureLayer = 0;
            state.captureSettings.Enable = true;
            state.captureSettings.RecordNewFile = false;
        }

        //Debug.Log("state.captureSettings " + state.captureSettings);

        //Debug.Log(Resources.FindObjectsOfTypeAll(typeof(CaptureSettings)).Length);

        if (!state.captureSettings.Enable) {
            return;
        }
        
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        if (state.captureSettings.RecordNewFile) {
            state.replayClassName = FindUniqueName();
            //state.replayClassName = DefaultName();
        } else {
            state.replayClassName = DefaultName();
        }
        
        output = new StringBuilder();
        WriteHeader();
    }
    
    public const string FolderName = "Replays/Editor/";

    public static string GetReplayProjectPath(string name) { // private
        //return Path.Combine(Path.Combine(Application.streamingAssetsPath, FolderName), name);
        return Path.Combine(Path.Combine(Application.dataPath, FolderName), name);
    }

    public static string GetReplayExternalPath(string name) { // private
        return Path.Combine(Path.Combine(Application.persistentDataPath, FolderName), name);
    }
    
    private static void Deinitialize() {

        output.AppendLine("});");
        output.AppendLine("return r;");
        output.AppendLine("}");

        output.AppendLine("public override List<Action> SuperExecute() {");
        output.AppendLine("     List<Action> actions = new List<Action>();");
        
        output.AppendLine("     actions = actions.Concat(Execute()).ToList();");
        for (int i = 0; i < _methodsNumber; i++) {
            output.AppendLine($"     actions = actions.Concat(Execute{i}()).ToList();");
        }

        output.AppendLine("     return actions;");
        output.AppendLine("}");

        /*
        public override List<Action> SuperExecute() {
            List<Action> actions = new List<Action>();
            actions = Execute().Concat(Execute2()).ToList();
            return actions;
        }
        */

        output.AppendLine("}");


        



#if UNITY_EDITOR
        var path = GetReplayProjectPath(state.replayClassName + ".cs"); // "Replay.cs"
#else
        var path = GetReplayExternalPath(state.replayClassName + ".cs");
#endif

        var directory = Path.GetDirectoryName(path);
        if (!Directory.Exists(directory)) {
            Directory.CreateDirectory(directory);
        }

        System.IO.StreamWriter file = new System.IO.StreamWriter(path);
        //System.IO.StreamWriter file = new System.IO.StreamWriter(Application.dataPath+@"\" + @"Editor\" + state.replayClassName +".cs");
        file.WriteLine(output.ToString());
        file.Close();
        //state.captureSettings.Enable = false;
    }
    
    private static void WriteHeader() {
        output.AppendLine("using System;");
        output.AppendLine("using System.Collections.Generic;");
        output.AppendLine("using UnityEngine;");
        output.AppendLine("using System.Linq;");
        output.AppendLine("public class "+ state.replayClassName + " : ReplayBase {");
        output.AppendLine("private List<Action> Execute() {");
        output.AppendLine("var r = new List<Action>();");
        output.AppendLine("r.Add(delegate{");
        }

    /*
    private static void WriteNewFrame() { 
    }
    */

    private static int _methodsNumber;
    private static void WriteNewMethod() {
        output.AppendLine("return r;");
        output.AppendLine("}");
        output.AppendLine("private List<Action> Execute" + _methodsNumber + "() {");
        Debug.Log("_methodsNumber  ------------------------ " + _methodsNumber);
        output.AppendLine("var r = new List<Action>();");
        _methodsNumber++;
    }

    protected static void WriteNewLine(string line)
    {
        output.AppendLine(line);
    }

    protected static bool IsDeclared(GameObject gameObject) {
        return state.declaredGameObjects.Contains(gameObject);
    }
    
    /*public StringBuilder Begin() {
        Check();
        return output.Append($"{variableName}");
    }*/


    public static string GetGameobjectPath(GameObject gameObject) {
        var o = gameObject.transform;
        string result = "/"+ gameObject.name;
        while (o.parent!=null) {
            o = o.parent;
            result = "/"+ o.gameObject.name + result;
        }
        return result;
    }

    protected void WriteAdd(string Parameter) {
        WriteAdd(gameObject, Parameter);
    }

    protected static void WriteAdd(GameObject gameObject, string Parameter) {
        output.Append("Add(0x")
            .Append(getVariableInstanceID(gameObject))
            .Append(", ")
            .Append(Parameter)
            .AppendLine(");");
        state.declaredGameObjects.Add(gameObject);
    }

    protected StringBuilder WriteGet() {
        return WriteGet(gameObject);
    }

    protected static StringBuilder WriteGet(GameObject gameObject) {
        return output.Append(GetGet(gameObject));
    }

    protected static string GetGet(GameObject gameObject) {
        return $"Get(0x{getVariableInstanceID(gameObject)})";
    }

    protected void WriteRemove() {
        WriteRemove(gameObject);
    }

    protected static void WriteRemove(GameObject gameObject) {
        output.Append($"Remove(0x{getVariableInstanceID(gameObject)});");
        state.declaredGameObjects.Remove(gameObject);
    }

    protected static void DeclareAndFind(GameObject gameObject) {
        if (!IsDeclared(gameObject)) {
            WriteAdd(gameObject, $"GameObject.Find(\"{GetGameobjectPath(gameObject)}\")");
        }
    }

    public static string getVariableInstanceID(GameObject gameObject) {
        return gameObject.GetInstanceID().ToString("X4");
    }

    public static string getVariableName(GameObject gameObject) {
        return "v" + getVariableInstanceID(gameObject);
    }

    public string variableName {
        get { return getVariableName(gameObject); }
    }

    protected virtual void OnFrame() {
    }



    /*
    void Update() {
        if (!state.captureSettings.Enable) return;
        if (CaptureLayer != state.captureSettings.CaptureLayer) return;
        if (state.needFrameFinalization) {
            WriteNewFrame();
            state.needFrameFinalization = false;
        }
    }

    void LateUpdate() {
        if (!state.captureSettings.Enable) return;
        if (CaptureLayer != state.captureSettings.CaptureLayer) return;
        OnFrame();
        state.needFrameFinalization = true;
    }
    */


    

    void FixedUpdate() {
        
        //if(!CaptureStarted)return;

        if (!state.captureSettings.Enable) return;
        if (CaptureLayer != state.captureSettings.CaptureLayer) return;
        
        if (state.needFrameFinalization) {


            output.AppendLine("});");
            
            // Тут надо проверку, что прошло достаточно кадров чтобы начать новый метод
            if (state.frame % 5000 == 0) {
                //Debug.Log(state.frame);
                WriteNewMethod();
            }

            output.AppendLine("r.Add(delegate{");
            state.frame++;

            state.needFrameFinalization = false;
        }
        
    }

    IEnumerator LateFixedUpdate() {
        
        while (true) {

            //Debug.Log("LateFixedUpdate");

            //if (!CaptureStarted) {
            //    yield return new WaitForFixedUpdate();
            //    continue;
            //}
            
            //Debug.Log("CaptureStarted   " + CaptureStarted);

            if (state.captureSettings && !state.captureSettings.Enable) {
                yield return new WaitForFixedUpdate();
                continue;
            }
            if (state.captureSettings && CaptureLayer != state.captureSettings.CaptureLayer) {
                yield return new WaitForFixedUpdate();
                continue;
            }

            //Debug.Log("Example  " + gameObject.name);

            OnFrame();
            state.needFrameFinalization = true;
            
            yield return new WaitForFixedUpdate();

        }
        
    }


    public static void CaptureMethod(GameObject gameObject, System.Type type, string methodName, string parameter = "") {

        if (!Application.isPlaying) return;
        if (!state.captureSettings.Enable) return;

        DeclareAndFind(gameObject);
        //WriteGet().AppendLine("");
        output.AppendLine("//-----------");
        output.Append(GetGet(gameObject) + ".GetComponent<" + type + ">()." + methodName + "(" + parameter +  ");");
        output.AppendLine("//-----------");
    }

    // Это пока не используется, потому что кажется всегда удобнее передовать готовую строку с параметрами в метод сверху
    public static void CaptureMethod(GameObject gameObject, System.Type type, string methodName, string[] parameters) {

        if (!Application.isPlaying) return;

        DeclareAndFind(gameObject);
        
        string parametersLine = "";
        for (int i = 0; i < parameters.Length; i++) {
            parametersLine += parameters[i];
            if (i != parameters.Length - 1) {
                parametersLine += ", ";
            }
        }
        
        output.Append(GetGet(gameObject) + ".GetComponent<" + type + ">()." + methodName + "(" + parametersLine + ");");
    }



    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCurrentMethod() {
        var st = new StackTrace();
        var sf = st.GetFrame(1);
        return sf.GetMethod().Name;
    }

}
