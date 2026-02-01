using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float playerSpeed;

    public InputActionAsset inputActions;
    private InputAction moveAction;

    private void OnEnable()
    {
        inputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        inputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        moveAction = InputSystem.actions.FindAction("Move");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInputs = moveAction.ReadValue<Vector2>();
        float forwardInput = moveInputs.y;

        playerRb.AddForce(Vector3.forward * playerSpeed * forwardInput);
    }
}