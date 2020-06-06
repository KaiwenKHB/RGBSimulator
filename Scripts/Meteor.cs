using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Vector3 respawnPosition;
    public int count;
    public GameObject childPic;
    // Start is called before the first frame update
    void Start()
    {
        respawnPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.collider.gameObject);
        count++;
        if(count >= 20)
        {
            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        childPic.SetActive(true);
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        count = 0;

        yield return new WaitForSeconds(0.5f);
        transform.position = respawnPosition;
        childPic.SetActive(false);
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
}
