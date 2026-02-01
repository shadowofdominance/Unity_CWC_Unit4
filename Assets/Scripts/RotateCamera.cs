using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCamera : MonoBehaviour
{
    public InputActionAsset inputActions;
    private InputAction moveAction;

    public float rotationSpeed;

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

        float horizontalInput = moveInputs.x;
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
