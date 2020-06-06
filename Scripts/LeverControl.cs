using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverControl : MonoBehaviour
{
    public GameObject prompt;
    public GameObject[] objectList;
    public bool withinProximity = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (withinProximity)
        {
            if(Input.GetKeyDown("e")){
                foreach(GameObject a in objectList)
                {
                    if (a.activeSelf)
                    {
                        a.SetActive(false);
                    }
                    else
                    {
                        a.SetActive(true);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            prompt.SetActive(true);
            withinProximity = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            prompt.SetActive(false);
            withinProximity = false;
        }
    }
}
