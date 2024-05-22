using System;
using UnityEngine;

namespace Systems
{
    public class PopupEventListener : MonoBehaviour
    {
        [SerializeField] private PopupEvent _popupEvent = default;
        private Action<ArtPiece> _callback = default;

        private void Awake()
        {
            _popupEvent.Register(this);
        }

        private void OnDestroy()
        {
            _popupEvent.Deregister(this);
        }

        public void RaiseEvent(ArtPiece data)
        {
            _callback.Invoke(data);
        }

        public void SetEvent(Action<ArtPiece> callback)
        {
            _callback = callback;
        }
    }
}