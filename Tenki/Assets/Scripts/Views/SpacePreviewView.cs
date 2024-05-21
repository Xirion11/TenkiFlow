using System.Collections;
using System.Collections.Generic;
using Controllers;
using Interfaces;
using UnityEngine;
using TMPro;

public class SpacePreviewView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _title = default;
    [SerializeField] private Transform _pieceContainer = default;
    [SerializeField] private PiecePreviewView _piecePreviewPrefab = default;
    
    private ISpacePreviewController _controller;
    
    private void Awake()
    {
        _controller = new SpacePreviewController();
        _controller.Setup(this);
    }
    
    public void Setup(Space space)
    {
        _title.SetText(space.Name);

        _controller.CreateLayout(_pieceContainer, space, _piecePreviewPrefab);
    }
}
