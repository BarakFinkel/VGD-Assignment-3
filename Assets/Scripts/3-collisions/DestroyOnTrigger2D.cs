﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField]
    List<string> collidingTags;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collidingTags.Contains(other.gameObject.tag))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}