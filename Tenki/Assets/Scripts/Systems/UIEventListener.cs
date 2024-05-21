using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class UIEventListener : MonoBehaviour
{
    [SerializeField] private UIEvent uiEvent = default;
    private Action<Space> _callback = default;

    private void Awake()
    {
        uiEvent.Register(this);
    }

    private void OnDestroy()
    {
        uiEvent.Deregister(this);
    }

    public void RaiseEvent(Space data)
    {
        _callback.Invoke(data);
    }

    public void SetEvent(Action<Space> callback)
    {
        _callback = callback;
    }
}
