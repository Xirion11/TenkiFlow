using Systems;
using UnityEngine;
using Views;

namespace Interfaces
{
    public interface IPopupController
    {
        void Setup(PopupView view, PopupPool pool);
        void ClosePopup();
    }
}
