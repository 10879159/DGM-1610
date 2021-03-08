using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Text ScoreValue;

    private static int score = 0;

    // Use this for initialization
    void Start () {
        ScoreValue.text = "";
    }
 
    // Update is called once per frame
    void Update () {
        ScoreValue.text = "" + score;
    }

    public static void AddScore()
    {
        score = score + 1;
    }
}
