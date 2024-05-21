using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Views;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private UIEventListener _uiEventListener = default;
    [SerializeField] private HomeMenuView _homeMenu = default;
    [SerializeField] private ContentSpaceView _contentSpace = default;

    private void Awake()
    {
        _uiEventListener.SetEvent(ShowSpaceUI);
    }

    private void ShowSpaceUI(Space data)
    {
        _homeMenu.gameObject.SetActive(false);
        _contentSpace.Setup(data);
        _contentSpace.SetVisibility(true);
    }
}
