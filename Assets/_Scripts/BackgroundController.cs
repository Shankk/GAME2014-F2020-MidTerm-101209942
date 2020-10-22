using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// BackgroundController.cs
/// Brian Viverios STU# 101209942 Last Modified 10/21/2020
/// Program Description: Controls the background objects of the scene, this gives the side scrolling illusion.
/// The Background will scroll to the end of their threshold and then teleport to their original location.
/// Last Revision: Rearranged The movement to be horizontal instead of vertical to match Landscape mode.
/// 
/// </summary>


public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
