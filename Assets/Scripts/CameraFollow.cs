﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject FocusTarget;
    public float Smoothness = 0.1F;
    public float Elasticity = 1F;

    private Vector3 _curPos;
    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    private void FixedUpdate()
    {
        var screenSize = new Vector3(_camera.pixelWidth, _camera.pixelHeight);

        var targetPos = FocusTarget.transform.position;
        targetPos.z = -10F;
        targetPos += (Input.mousePosition - screenSize / 2F) / ((screenSize.x + screenSize.y) / 2F) * Elasticity;

        _curPos = Vector3.Lerp(_curPos, targetPos, Smoothness);

        transform.position = _curPos;
    }
}
