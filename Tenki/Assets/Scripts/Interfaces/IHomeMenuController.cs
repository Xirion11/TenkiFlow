using UnityEngine;
using Views;

namespace Interfaces
{
    public abstract class IHomeMenuController
    {
        public abstract void Setup(HomeMenuView view);
        public abstract void CreateLayout(Transform transform, Space[] spaces, SpacePreviewView spacePreviewPrefab);
    }
}
