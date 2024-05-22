using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Views;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private UIEventListener _onSpaceClickedListener = default;
    [SerializeField] private UIEventListener _onBackToHomeListener = default;
    [SerializeField] private HomeMenuView _homeMenu = default;
    [SerializeField] private ContentSpaceView _contentSpace = default;

    private void Awake()
    {
        _onSpaceClickedListener.SetEvent(ShowUI);
        _onBackToHomeListener.SetEvent(BackToHome);
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
}
