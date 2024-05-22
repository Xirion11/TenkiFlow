using System;
using UnityEngine;

namespace Systems
{
    public class UIEventListener : MonoBehaviour
    {
        [SerializeField] private UIEvent _uiEvent = default;
        private Action<Space> _callback = default;

        private void Awake()
        {
            _uiEvent.Register(this);
        }

        private void OnDestroy()
        {
            _uiEvent.Deregister(this);
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
}
