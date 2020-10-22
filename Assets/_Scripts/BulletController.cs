using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// BulletController.cs
/// Brian Viverios STU# 101209942 Last Modified 10/21/2020
/// Program Description: Controls the Bullet Objects movement, this includes the speed, rotation and boundary.
/// Aswell as provide the bullet spawning.
/// Last Revision: Rearranged The movement to be horizontal instead of vertical to match Landscape mode.
/// 
/// </summary>

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
