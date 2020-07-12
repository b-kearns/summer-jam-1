using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using static UnityEngine.InputSystem.InputAction;
using static UnityEngine.InputSystem.InputAction.CallbackContext;

public class StartMenu : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject startUI;
    [SerializeField] public CarGroup carGroup;
    // Start is called before the first frame update
    void Start()
    {
        scoreUI.SetActive(false);
        startUI.SetActive(true);
        carGroup = GameObject.FindGameObjectWithTag("Cars").GetComponent<CarGroup>();
    }

    private void Update()
    {
        if(carGroup == null)
        {
            carGroup = GameObject.FindGameObjectWithTag("Cars").GetComponent<CarGroup>();
        }
    }


    public void StartGame(CallbackContext callbackContext)
    {
        scoreUI.SetActive(true);
        startUI.SetActive(false);
        carGroup.StartMovement();
    }
}
