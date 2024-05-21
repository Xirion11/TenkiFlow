using UnityEngine;
using Views;

namespace Interfaces
{
    public interface IHomeMenuController
    {
        public void Setup(HomeMenuView view);
        public void CreateLayout(Transform transform, Space[] spaces, SpacePreviewView spacePreviewPrefab);
    }
}
