using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// EnemyController.cs
/// Brian Viverios STU# 101209942 Last Modified 10/21/2020
/// Program Description: Controls the Enemy Objects movement, this includes the speed, rotation and boundary.
/// Last Revision: Rearranged The movement to be vertical instead of horizontal to match Landscape mode.
/// 
/// </summary>

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
