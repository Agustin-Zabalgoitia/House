using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private PlayerController playerController;

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else _instance = this;

        Cursor.visible = false;

        playerController = new PlayerController();
    }

    private void OnEnable()
    {
        playerController.Enable();
    }

    private void OnDisable()
    {
        playerController.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerController.PlayerMovement.Move.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()
    {
        return playerController.PlayerMovement.LookAround.ReadValue<Vector2>();
    }
}
