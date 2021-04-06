using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// For Editor only sprites, disables when game is in play
/// </summary>

public class DisappearInGame : MonoBehaviour
{
    SpriteRenderer sprite;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
    }
}
