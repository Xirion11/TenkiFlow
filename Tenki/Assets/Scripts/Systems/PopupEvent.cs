using System.Collections.Generic;
using Interfaces;
using UnityEngine;

namespace Systems
{
    [CreateAssetMenu(menuName = "Popup Event", fileName = "New Popup Event")]
    public class PopupEvent : IEvent
    {
        private HashSet<PopupEventListener> _listeners = new HashSet<PopupEventListener>();
        
        public void Invoke(ArtPiece data)
        {
            foreach (var globalEventListener in _listeners)
            {
                globalEventListener.RaiseEvent(data);
            }
        }
        
        public void Register(PopupEventListener uiEventListener) => _listeners.Add(uiEventListener);
        
        public void Deregister(PopupEventListener uiEventListener) => _listeners.Remove(uiEventListener);
    }
}