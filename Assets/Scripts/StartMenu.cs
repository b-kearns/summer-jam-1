using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using static UnityEngine.InputSystem.InputAction;
using static UnityEngine.InputSystem.InputAction.CallbackContext;
using TMPro;


public class StartMenu : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject startUI;
    [SerializeField] public CarGroup carGroup;

    public TMP_Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI.SetActive(false);
        startUI.SetActive(true);
        carGroup = GameObject.FindGameObjectWithTag("Cars").GetComponent<CarGroup>();

        if (!PlayerPrefs.HasKey("Highscore")) { PlayerPrefs.SetFloat("Highscore", 0f); PlayerPrefs.Save(); }
    }

    private void Update()
    {
        if(carGroup == null)
        {
            carGroup = GameObject.FindGameObjectWithTag("Cars").GetComponent<CarGroup>();
        }

        if ( !PlayerPrefs.HasKey("Highscore") || PlayerPrefs.GetFloat("Highscore") <= 0) { highscore.text = "HIGHSCORE: 0"; }
        highscore.text = "HIGHSCORE: " + PlayerPrefs.GetFloat("Highscore");
    }


    public void StartGame(CallbackContext callbackContext)
    {
        scoreUI.SetActive(true);
        startUI.SetActive(false);
        carGroup.StartMovement();
    }
}
