using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public static class GameObjectExtension {

    public static void SetLocalPose(this GameObject gameObject, float lpx, float lpy, float lpz, float lrx, float lry, float lrz,
        float lrw) {
        gameObject.transform.localPosition = new Vector3(lpx, lpy, lpz);
        gameObject.transform.localRotation = new Quaternion(lrx, lry, lrz, lrw);
    }


    public static void SetWorldPose(this GameObject gameObject, float lpx, float lpy, float lpz, float lrx, float lry, float lrz,
        float lrw) {
        gameObject.transform.position = new Vector3(lpx, lpy, lpz);
        gameObject.transform.rotation = new Quaternion(lrx, lry, lrz, lrw);
    }


    public static void SetComponentEnabled(this GameObject gameObject,string name, bool enabled) {
        var components = gameObject.GetComponents<Behaviour>();
        foreach (var c in components) {
            if (c.GetType().Name == name) {
                c.enabled = enabled;
            }
        }
    }

}

public abstract class ReplayBase : MonoBehaviour {  // MonoBehaviour - no

    private List<Action> frames = new List<Action>();
    private uint frame = 0;

    private Dictionary<uint, GameObject> _gameobjects = new Dictionary<uint, GameObject>();

    protected GameObject Get(uint index) {
        return _gameobjects[index];
    }
    protected void Add(uint index, GameObject gameObject) {
        _gameobjects.Add(index, gameObject);
    }
    protected void Remove(uint index) {
        GameObject.DestroyImmediate(_gameobjects[index]);
        _gameobjects.Remove(index);
    }
    
    public ReplayBase() {
        frames = SuperExecute();
        frame = 0;
    }

    public void MoveTo(int destFrame) {
        //Debug.Log("MoveTo");
        while (frame < destFrame) {
            if (!MoveNext()) return;
        }
    }
    
    bool MoveNext() {
        UpdateAnimationsAndParticleSystems();
        if (frame >= frames.Count) return false;
        //Debug.Log("frames.Count =    " + frames.Count);
        frames[(int)frame](); // <- вызов методов в данном кадре
        frame++;
        EditorUtility.SetDirty(GameObject.FindObjectOfType<Transform>());
        return frame < frames.Count;
    }


    void UpdateAnimationsAndParticleSystems() {

        // почему-то анимация работает неправильно при промотке назад  // < --------------------------------------------------
        Animator[] animators = FindObjectsOfType<Animator>();
        foreach (var an in animators) {
            // тут надо исключить аниматор камеры
            an.Update(Time.fixedDeltaTime);
        }

        ParticleSystem[] particleSystems = FindObjectsOfType<ParticleSystem>();
        //Debug.Log(particleSystems.Length);
        foreach (var ps in particleSystems) {
            ps.Simulate(Time.fixedDeltaTime, true, false, false);
        }

    }

    public abstract List<Action> SuperExecute();

    public int FrameCount {
        get { return frames.Count; }
    }

    public static GameObject CreateGameObject(string name, string prefabName) {

        if (!string.IsNullOrEmpty(prefabName)) {
            var names = AssetDatabase.FindAssets(prefabName+ " t:prefab");
            if (names.Length > 0) {
                var path = AssetDatabase.GUIDToAssetPath(names[0]);
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                var newGameObject = GameObject.Instantiate(prefab);
                newGameObject.name = name;
                return newGameObject;
            }
        }
        return new GameObject(name);
    }

    public static T m2s<T>(params UInt64[] value) {
        GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
        T result = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
        handle.Free();
        return result;
    }
    
    

}
