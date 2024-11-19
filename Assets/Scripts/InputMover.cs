using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Hide : MonoBehaviour
{
    [SerializeField]
    private float speed = 100f;
    [SerializeField]
    private InputAction up = new InputAction(type: InputActionType.Button); // Define the button action
    [SerializeField]
    private InputAction down = new InputAction(type: InputActionType.Button); // Define the button action
    [SerializeField]
    private InputAction right = new InputAction(type: InputActionType.Button); // Define the button action
    [SerializeField]
    private InputAction left = new InputAction(type: InputActionType.Button); // Define the button action

    private void OnEnable()
    {
        up.Enable(); // Enable the input action
        down.Enable(); // Enable the input action
        right.Enable(); // Enable the input action
        left.Enable(); // Enable the input action
    }

    private void OnDisable()
    {
        up.Disable(); // Disable the input action
        down.Disable();
        right.Disable();
        left.Disable();
    }

    void Update()
    {
        // Check if the button was pressed this frame
        if (up.WasPressedThisFrame())
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
        if (down.WasPressedThisFrame())
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
        if (right.WasPressedThisFrame())
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (left.WasPressedThisFrame())
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
