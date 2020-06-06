using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSmall : MonoBehaviour
{
    public float enlargeSpeed = 1;
    public int range = 35;
    public int i = 0;
    public bool big = true;
    public bool wait = false;
    public int waitFrame = 10;
    public int waitCurrent = 0;

    // Update is called once per frame
    void Update()
    {
        if (i == range)
        {
            big = false;
            if (waitCurrent == 0)
            {
                waitCurrent = waitFrame;
            }
        }
        else if (i == 0)
        {
            big = true;
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
            if (big)
            {
                Vector3 movement = new Vector3(1f, 1f, 1f);
                transform.localScale += movement * Time.deltaTime * enlargeSpeed;
                i++;
            }
            else
            {
                Vector3 movement = new Vector3(-1f, -1f, -1f);
                transform.localScale += movement * Time.deltaTime * enlargeSpeed;
                i--;
            }
        }
    }
}
