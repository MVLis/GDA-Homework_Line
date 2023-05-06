using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineByMouse : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    
    
    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //currentPosition.z = 0;
            Debug.Log(currentPosition);
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount-1,currentPosition);
        }
     
        else if (Input.GetMouseButtonUp(0))
        {
            _lineRenderer.positionCount = 0;
        }
    }
}
