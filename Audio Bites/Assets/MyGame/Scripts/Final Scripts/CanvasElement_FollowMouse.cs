using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Not complete, needs more fiddling: https://www.youtube.com/watch?v=JBn9cJvTJnA
/// </summary>

public class CanvasElement_FollowMouse : MonoBehaviour
{
    public RectTransform movingObject;
    public Vector3 offset;
    public RectTransform basisObject;
    public Camera cam;

    private void Update()
    {
        Vector3 pos = Input.mousePosition + offset;
        pos.z = basisObject.position.z;
        movingObject.position = cam.ScreenToWorldPoint(pos);
    }
}
