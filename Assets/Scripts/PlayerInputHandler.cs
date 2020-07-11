using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;
using static UnityEngine.InputSystem.InputAction;
using static UnityEngine.InputSystem.InputAction.CallbackContext;

public class PlayerInputHandler : MonoBehaviour
{
    [Header("Player Prefab")]
    [SerializeField] private GameObject playerInstance0 = null;
    [SerializeField] private GameObject playerInstance1 = null;
    [SerializeField] private GameObject playerInstance2 = null;
    public int playerIndex;

    private PlayerInput playerInput;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        this.playerIndex = playerInput.playerIndex;
        this.name = "Player Controller :: " + this.playerIndex;
    }

    private void FixedUpdate()
    {
    }

    public void OnAccelerateCar1(CallbackContext context)
    {
        playerInstance0.GetComponent<CarMovement>().SetAcceleration(context.ReadValue<float>());
    }

    public void OnRotateCar1(CallbackContext context)
    {
        playerInstance0.GetComponent<CarMovement>().SetRotation(context.ReadValue<float>());
    }

    public void OnAccelerateCar2(CallbackContext context)
    {
        playerInstance1.GetComponent<CarMovement>().SetAcceleration(context.ReadValue<float>());
    }

    public void OnRotateCar2(CallbackContext context)
    {
        playerInstance1.GetComponent<CarMovement>().SetRotation(context.ReadValue<float>());
    }

    public void OnAccelerateCar3(CallbackContext context)
    {
        playerInstance2.GetComponent<CarMovement>().SetAcceleration(context.ReadValue<float>());
    }

    public void OnRotateCar3(CallbackContext context)
    {
        playerInstance2.GetComponent<CarMovement>().SetRotation(context.ReadValue<float>());
    }

    

}
