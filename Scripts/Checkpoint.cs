using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public ProtagonistControl protagonist;
    public Vector3 modifier = new Vector3(0f, 5f, 0f);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            protagonist.spawnPoint = transform.position+modifier;
            Destroy(gameObject);

        }
    }
}
