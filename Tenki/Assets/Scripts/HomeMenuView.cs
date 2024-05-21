using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeMenuView : MonoBehaviour
{
    [SerializeField] private SpaceView _spacePrefab = default;
    [SerializeField] private Space[] _spaces = default;

    private Transform _transform;
    
    private void Awake()
    {
        _transform = this.transform;
    }

    private void Start()
    {
        foreach (var space in _spaces)
        {
            var spacePrefab = Instantiate(_spacePrefab, _transform);
            spacePrefab.gameObject.name = space.Name;
            spacePrefab.Setup(space);
        }
    }
}
