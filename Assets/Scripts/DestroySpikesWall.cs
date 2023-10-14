using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpikesWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            Destroy(collision.gameObject);
        }

    }
}
