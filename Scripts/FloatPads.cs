using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatPads : MonoBehaviour
{
    public float moveSpeed = 5;
    public int range = 0;
    public int i = 0;
    public bool right = true;
    public bool wait = false;
    public int waitFrame = 10;
    public int waitCurrent = 0;

    // Update is called once per frame
    void Update()
    {
        if (i == range)
        {
            right = false;
            if (waitCurrent == 0)
            {
                waitCurrent = waitFrame;
            }
        }
        else if (i == 0)
        {
            right = true;
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
            if (right)
            {
                Vector3 movement = new Vector3(1f, 0f, 0f);
                transform.position += movement * Time.deltaTime * moveSpeed;
                i++;
            }
            else
            {
                Vector3 movement = new Vector3(-1f, 0f, 0f);
                transform.position += movement * Time.deltaTime * moveSpeed;
                i--;
            }
        }
    }
}
