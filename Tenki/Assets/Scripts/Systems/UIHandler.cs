using Systems;
using UnityEngine;
using Views;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private UIEventListener _onSpaceClickedListener = default;
    [SerializeField] private UIEventListener _onBackToHomeListener = default;
    [SerializeField] private PopupEventListener _onShowPopupListener = default;
    [SerializeField] private HomeMenuView _homeMenu = default;
    [SerializeField] private ContentSpaceView _contentSpace = default;
    [SerializeField] private Transform _popupContainer = default;
    [SerializeField] private PopupPool _pool = default;

    private void Awake()
    {
        _onSpaceClickedListener.SetEvent(ShowUI);
        _onBackToHomeListener.SetEvent(BackToHome);
        _onShowPopupListener.SetEvent(ShowPopup);
    }

    private void BackToHome(Space data)
    {
        _homeMenu.gameObject.SetActive(true);
        _contentSpace.SetVisibility(false);
    }

    private void ShowUI(Space data)
    {
        _homeMenu.gameObject.SetActive(false);
        _contentSpace.Setup(data);
        _contentSpace.SetVisibility(true);
    }
    
    private void ShowPopup(ArtPiece data)
    {
        var popup = _pool.Get(_popupContainer);
        popup.Setup(data, _pool);
    }
}
