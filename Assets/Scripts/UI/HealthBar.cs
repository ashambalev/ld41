﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public PlayerController Player;

    private RectTransform _rt;
    private Vector2 _originalSize;
    // Use this for initialization
    void Start()
    {
        _rt = GetComponent<RectTransform>();
        _originalSize = _rt.sizeDelta;
    }

    // Update is called once per frame
    void Update()
    {
        _rt.sizeDelta = new Vector2(_originalSize.x * (Player.Health / (float)Player.MaxHealth), _originalSize.y);
    }
}
