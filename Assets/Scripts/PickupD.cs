using UnityEngine;
using UnityEngine.InputSystem;

public class PickupD : MonoBehaviour
{
    public GameObject scissors;
    private bool isGrabbing = false;

    void Update()
    {
        // Check if the A button is pressed
        if (Gamepad.current != null && Gamepad.current.buttonSouth.isPressed)
        {
            if (isGrabbing && scissors != null)
            {
                // Set deformity's transform parent to scissors
                transform.parent = scissors.transform;
                Debug.Log("Deformity picked up by scissors!");
            }
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == scissors)
        {
            isGrabbing = true;
            Debug.Log("Scissors entered deformity trigger");
        }
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == scissors)
        {
            isGrabbing = false;
            Debug.Log("Scissors exited deformity trigger");
        }
    }
}
