using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// z axis, clockwise -. counter-clockwise +
public class Rotation : MonoBehaviour
{
    public float anglePerSec;
    public bool clockwise;
    private Vector3 rotateAngle;

    // Update is called once per frame
    void Update()
    {
        if (clockwise)
        {
            rotateAngle = new Vector3(0f, 0f, -1f * anglePerSec / 60f);
            transform.Rotate(rotateAngle);
        }
        else
        {
            rotateAngle = new Vector3(0f, 0f, 1f * anglePerSec / 60f);
            transform.Rotate(rotateAngle);
        }
    }
}
