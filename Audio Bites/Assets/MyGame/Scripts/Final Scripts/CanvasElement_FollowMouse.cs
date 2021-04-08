using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Text canvas element that follows precisely with the cursor: https://www.youtube.com/watch?v=JBn9cJvTJnA
/// </summary>

public class CanvasElement_FollowMouse : MonoBehaviour
{
    //Variables
    public RectTransform movingObject;
    public Vector3 offset;
    //Basis Object is an object that is set in the centre of the screen to help centre the moving text (apparently this is necessary for text elements or else the text moves strangely on the screen with a simple follow script)
    public RectTransform basisObject;
    public Camera cam;

    private void Update()
    {
        //Moves the text element to the mouse position adding the offset, judging its movement based on the basis object
        Vector3 pos = Input.mousePosition + offset;
        pos.z = basisObject.position.z;
        movingObject.position = cam.ScreenToWorldPoint(pos);
    }
}
