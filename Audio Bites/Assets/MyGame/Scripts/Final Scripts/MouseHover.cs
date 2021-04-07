using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// To check where the mouse is hovering and to activate stuff based on collisions
/// </summary>

public class MouseHover : MonoBehaviour
{

    private bool hovering = false;

    private void Update()
    {
        //Follow the cursor in sync
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (hovering == false)
        {

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LightSwitch")
        {
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (hovering == true)
        {
            hovering = false;
        }
    }

}
