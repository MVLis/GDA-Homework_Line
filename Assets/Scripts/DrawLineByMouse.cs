using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DrawLineByMouse : MonoBehaviour
{
    [SerializeField] private float _deep = 10;
    
    private LineRenderer _lineRenderer;
    private Camera _camera;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _camera=Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lineRenderer.positionCount = 0;
        }
        
        if (Input.GetMouseButton(0))
        {
            var currentPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _deep);
            var drawingPoint = _camera.ScreenToWorldPoint(currentPosition);
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount-1,drawingPoint);
        }
     
        
    }
}
