using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ColorChange : MonoBehaviour
{
    public GameObject red;
    public GameObject green;
    public GameObject blue;
    public Camera camera;
    public GameObject redBk;
    public GameObject greenBk;
    public GameObject blueBk;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (red.activeInHierarchy)
            {
                green.SetActive(true);
                greenBk.SetActive(true);
                red.SetActive(false);
                redBk.SetActive(false);
            }
            else if (green.activeInHierarchy)
            {
                blue.SetActive(true);
                blueBk.SetActive(true);
                green.SetActive(false);
                greenBk.SetActive(false);
            }
            else
            {
                red.SetActive(true);
                redBk.SetActive(true);
                blue.SetActive(false);
                blueBk.SetActive(false);
            }

            /*for(int i = 0; i < 25; i++)
            {
                camera.orthographicSize += 0.1f;
                System.Threading.Thread.Sleep(10);
            }
            for (int i = 0; i < 15; i++)
            {
                camera.orthographicSize -= 0.2f;
                System.Threading.Thread.Sleep(10);
            }
            for (int i = 0; i < 10; i++)
            {
                camera.orthographicSize += 0.1f;
                System.Threading.Thread.Sleep(10);
            }*/

        }
    }

}
