using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets the cursor to the proper texture
/// </summary>

public class CursorImage : MonoBehaviour
{
    //The cursor settings
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    
    void Start()
    {
        //Cursor Setting Code
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
}
