using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UI Event", fileName = "New UI Event")]
public class UIEvent : ScriptableObject
{//
    private HashSet<UIEventListener> _listeners = new HashSet<UIEventListener>();
    
    public void Invoke(Space data)
    {
        foreach (var globalEventListener in _listeners)
        {
            globalEventListener.RaiseEvent(data);
        }
    }

    public void Register(UIEventListener uiEventListener) => _listeners.Add(uiEventListener);
    
    public void Deregister(UIEventListener uiEventListener) => _listeners.Remove(uiEventListener);
}