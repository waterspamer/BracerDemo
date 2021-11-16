using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

public class CaptureProperties : Capture
{
    [Serializable]
    public struct ComponentMember {
        public string componentTypeFullName;
        public string memberName;
        [NonSerialized]
        public string previousCode;
    }

    [SerializeField]
    public ComponentMember[] ComponentMembers;
    


    public static bool TypeSupported(Type type) {
        if (type == typeof(GameObject)) return true;
        if (type == typeof(string)) return true;
        if (type.IsValueType) return true;
        return false;
    }

    public static bool MemberSupported(MemberInfo memberInfo) {
        if (memberInfo is FieldInfo) {
            var fi = memberInfo as FieldInfo;
            return TypeSupported(fi.FieldType);
        }
        if (memberInfo is PropertyInfo) {
            var pi = memberInfo as PropertyInfo;
            if (!pi.CanRead) return false;
            if (!pi.CanWrite) return false;
            return TypeSupported(pi.PropertyType);
        }

        return false;
    }

    /*public static UInt64[] s2m<T>(T value) {
        return s2m(value, value.GetType());
    }*/

    public static UInt64[] s2m(object value) {
        Type t = value.GetType();

        int numElements = (Marshal.SizeOf(t) - 1) / 8 + 1;
        var result = new UInt64[numElements];

        GCHandle handle = GCHandle.Alloc(result, GCHandleType.Pinned);
        Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), false);

        handle.Free();
        return result;
    }

    public static string getAssignCode(object value) {
        Type t = value.GetType();
        if (t == typeof(bool)) {
            return (bool)value ? "true" : "false";
        }

        if (t == typeof(string)) {
            return "\"" + value.ToString() + "\"";
        }

        if (t == typeof(Color)) {
            Color c = (Color)value;
            return $"new Color({c.r}f,{c.g}f,{c.b}f)";
        }

        if (t == typeof(Vector3)) {
            Vector3 v = (Vector3)value;
            return $"new Vector3({v.x}f,{v.y}f,{v.z}f)";
        }

        if (t == typeof(Quaternion)) {
            Quaternion q = (Quaternion)value;
            return $"new Quaternion({q.x}f,{q.y}f,{q.z}f,{q.w}f)";
        }

        if (t == typeof(float)) {
            return value.ToString() + "f";
        }

        if (t.IsPrimitive) {
            return value.ToString();
        }

        if (t.IsEnum) {
            return t.FullName + "." + value;
        }

        if (t == typeof(GameObject)) {
            DeclareAndFind((GameObject)value);

            return GetGet((GameObject)value);
        }

        if (t.IsValueType) {
            var memory = s2m(value);
            string result = "m2s<"+t.FullName+">(" + string.Join(",", memory.Select(x=>"0x"+x.ToString("X1"))) +")";
            return result;
        }

        return null;
    }

    public static object getValue(MemberInfo memberInfo, object Obj) {
        if (memberInfo is FieldInfo) {
            return (memberInfo as FieldInfo).GetValue(Obj);
        }
        if (memberInfo is PropertyInfo) {
            return (memberInfo as PropertyInfo).GetValue(Obj);
        }
        return null;
    }


    protected override void OnFrame() {
        base.OnFrame();
        var components = GetComponents(typeof(Component));

        for (int m=0; m<ComponentMembers.Length; m++) {

            var component = components.FirstOrDefault(x => x.GetType().FullName == ComponentMembers[m].componentTypeFullName);
            if (component) {

                var memberInfo = component.GetType().GetMember(ComponentMembers[m].memberName).FirstOrDefault(x=>true);
                if (memberInfo!=null) {
                    var value = getValue(memberInfo, component);
                    var code = getAssignCode(value);

                    if (ComponentMembers[m].previousCode != code) {
                        ComponentMembers[m].previousCode = code;
                        if (code != "") {
                            DeclareAndFind(gameObject);
                            WriteGet().AppendLine($".GetComponent<{ComponentMembers[m].componentTypeFullName}>().{ComponentMembers[m].memberName} = {code};");
                        }
                    }

                }
            }

        }

    }





}
