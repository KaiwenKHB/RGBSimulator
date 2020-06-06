using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float moveSpeed = 1;
    public int range = 35;
    public int i = 0;
    public bool up = true;
    public bool wait = false;
    public int waitFrame = 10;
    public int waitCurrent = 0;

    // Update is called once per frame
    void Update()
    {
        if (i == range)
        {
            up = false;
            if(waitCurrent == 0)
            {
                waitCurrent = waitFrame;
            }
        }
        else if (i == 0)
        {
            up = true;
            if (waitCurrent == 0)
            {
                waitCurrent = waitFrame;
            }
        }

        if (waitCurrent != 0)
        {
            waitCurrent--;
        }

        if (waitCurrent == 0)
        {
            if (up)
            {
                Vector3 movement = new Vector3(0f, 1f, 0f);
                transform.position += movement * Time.deltaTime * moveSpeed;
                i++;
            }
            else
            {
                Vector3 movement = new Vector3(0f, -1f, 0f);
                transform.position += movement * Time.deltaTime * moveSpeed;
                i--;
            }
        }
    }
}
