using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public static int coinAmount;
    public int levelMaxAmount;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Coin amount: " + coinAmount + "/" + levelMaxAmount;
        if(coinAmount == levelMaxAmount)
        {
            text.text += "\nGood Job!";
        }
    }
}
