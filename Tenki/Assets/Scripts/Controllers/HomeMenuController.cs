using Interfaces;
using UnityEngine;
using Views;

namespace Controllers
{
    public class HomeMenuController : IHomeMenuController
    {
        private HomeMenuView _view;
        
        public void Setup(HomeMenuView view)
        {
            _view = view;
        }

        public void CreateLayout(Transform transform, Space[] spaces, SpacePreviewView spacePreviewViewPrefab)
        {
            foreach (var space in spaces)
            {
                var spacePrefab = GameObject.Instantiate(spacePreviewViewPrefab, transform);
                spacePrefab.gameObject.name = space.Name;
                spacePrefab.Setup(space);
            }
        }
    }
}
