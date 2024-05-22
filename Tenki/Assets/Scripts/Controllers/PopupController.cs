using Interfaces;
using Systems;
using Views;

namespace Controllers
{
    public class PopupController : IPopupController
    {
        private PopupPool _pool;
        private PopupView _view;

        public void Setup(PopupView view, PopupPool pool)
        {
            _pool = pool;
            _view = view;
        }

        public void ClosePopup()
        {
            _pool.ReturnToPool(_view);
        }
    }
}
