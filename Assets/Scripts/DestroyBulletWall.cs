using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {   //Destroy Bullet
        if (collision.gameObject.tag == "bullets")
        {
            Destroy(collision.gameObject);
        }
    }
}