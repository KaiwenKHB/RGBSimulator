using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour
{
    public GameObject disabled;
    public GameObject obj_enabled;

    public void enableDisable()
    {
        disabled.SetActive(false);
        obj_enabled.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
