using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    public float playerScore = 0;
    public TMP_Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerScore);
        scoreUI.text = playerScore.ToString();
    }
}