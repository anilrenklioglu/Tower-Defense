using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilClasses
{
    private static Camera mainCamera;
    
    public static Vector3 GetMousePosition()
    {
        if (mainCamera == null){ mainCamera = Camera.main;}
        
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        mousePos.z = 0f;

        return mousePos;
    }
}
