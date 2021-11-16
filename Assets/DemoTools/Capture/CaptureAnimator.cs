using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Animations;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class CaptureAnimator : Capture
{


    public List<string> AnimatorStateNames;
    private Animator _animator => GetComponent<Animator>();

    private AnimatorStateInfo _animatorStateInfo;

    //private AnimatorState _animatorState;

    private AnimatorControllerParameter[] _animatorParameters;

    protected override void Awake()
    {
        base.Awake();
        //_animator = GetComponent<Animator>();
        _animatorStateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        _animatorParameters = _animator.parameters;

    }

    private List<AnimatorControllerParameter> GetDiffs()
    {
        var res = new List<AnimatorControllerParameter>();
        
        for (int i = 0; i < _animator.parameters.Length; i++)
        {
            if (!Equals(GetParameterValue(_animator.parameters[i]), GetParameterValue(_animatorParameters[i])))
                res.Add(_animator.parameters[i]);
        }

        _animatorParameters = _animator.parameters;

        return res;
    }

    private object GetParameterValue(AnimatorControllerParameter param)
    {
        switch (param.type)
        {
            case AnimatorControllerParameterType.Bool:
            {
                return _animator.GetBool(param.name);
            }
            case AnimatorControllerParameterType.Float:
            {
                return _animator.GetFloat(param.name);
            }
            case AnimatorControllerParameterType.Int:
            {
                return _animator.GetInteger(param.name);
            }
            case AnimatorControllerParameterType.Trigger:
            {
                return _animator.GetCurrentAnimatorStateInfo(0);
            }
            default:
            {
                return null;
            }
        }
    }

    private string GetSetterString(AnimatorControllerParameter param)
    {
        switch (param.type)
        {
            case AnimatorControllerParameterType.Bool:
            {
                return $".SetBool(\"{param.name}\", {_animator.GetBool(param.name)})";
            }
            case AnimatorControllerParameterType.Float:
            {
                return $".SetFloat(\"{param.name}\", {_animator.GetFloat(param.name)})";
            }
            case AnimatorControllerParameterType.Int:
            {
                return $".SetInteger(\"{param.name}\", { _animator.GetInteger(param.name)})";
            }
            case AnimatorControllerParameterType.Trigger:
            {
                return $".SetTrigger(\"{param.name}\")";
            }
            default:
            {
                return null;
            }
        }
    }

    private void WriteDiffs()
    {
        //var anim = GetComponent<Animator>();
       // var ac = anim.runtimeAnimatorController as AnimatorController;
        
        foreach (var param in _animatorParameters)
        {
            WriteGet().AppendLine($".GetComponent<Animator>(){GetSetterString(param)};");
        }
    }


    private void WriteStateDiffs()
    {
        foreach (var stateName in AnimatorStateNames)
        {
            if (_animator.GetCurrentAnimatorStateInfo(0).IsName(stateName))
            {
                //_animator.Play(stateName, 0, _animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
                WriteGet().AppendLine($".GetComponent<Animator>().Play(\"{stateName}\", 0, {_animator.GetCurrentAnimatorStateInfo(0).normalizedTime}f);"); //_animator.Play();
                //WriteGet().AppendLine($".GetComponent<Animator>().SetTrigger(\"{stateName}\");");
                //WriteGet().AppendLine($".GetComponent<Animator>().SetFloat(\"{stateName}\", {_animator.GetCurrentAnimatorStateInfo(0).normalizedTime}f);");

            }
                
        }
        
    }
    
    protected override void OnFrame()
    {
        DeclareAndFind(gameObject);



        WriteStateDiffs();
        //WriteGet().AppendLine($".GetComponent<Animator>(). = {BoolToString(Behaviour.enabled)};");
    }
}
