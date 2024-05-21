using Interfaces;
using UnityEngine;
using Views;

namespace Controllers
{
    public class HomeMenuController : IHomeMenuController
    {
        private HomeMenuView _view;
        
        public override void Setup(HomeMenuView view)
        {
            _view = view;
        }

        public override void CreateLayout(Transform transform, Space[] spaces, SpaceView spaceViewPrefab)
        {
            foreach (var space in spaces)
            {
                var spacePrefab = GameObject.Instantiate(spaceViewPrefab, transform);
                spacePrefab.gameObject.name = space.Name;
                spacePrefab.Setup(space);
            }
        }
    }
}
