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
    [SerializeField] public CarGroup carGroup;

    void Start()
    {
        //carGroup = GameObject.FindGameObjectWithTag("Cars").GetComponent<CarGroup>();
    }

    private void Update()
    {
        if (carGroup == null)
        {
            carGroup = GameObject.FindGameObjectWithTag("Cars").GetComponent<CarGroup>();
        }
    }

    public void OnCrash()
    {
        scoreUI.SetActive(false);
        gameOverUI.SetActive(true);
        carGroup.StopMovement();
        StartCoroutine(reset());
    } 

    IEnumerator reset()
    {
        if (GetComponent<Score>().playerScore > PlayerPrefs.GetFloat("Highscore"))
        {
            PlayerPrefs.SetFloat("Highscore", GetComponent<Score>().playerScore);
            PlayerPrefs.Save();
        }

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
