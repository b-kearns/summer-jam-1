using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject gameOverUI;

    public void OnCrash()
    {
        scoreUI.SetActive(false);
        gameOverUI.SetActive(true);
        StartCoroutine(reset());
    } 

    IEnumerator reset()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
