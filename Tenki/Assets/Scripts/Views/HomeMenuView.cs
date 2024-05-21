using Controllers;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Views
{
    public class HomeMenuView : MonoBehaviour
    {
        [SerializeField] private SpacePreviewView spacePreviewPrefab = default;
        [SerializeField] private Space[] _spaces = default;

        private Transform _transform;
        private IHomeMenuController _controller;
    
        private void Awake()
        {
            _transform = this.transform;
            _controller = new HomeMenuController();
            _controller.Setup(this);
        }

        private void Start()
        {
            _controller.CreateLayout(_transform, _spaces, spacePreviewPrefab);
        }
    }
}
