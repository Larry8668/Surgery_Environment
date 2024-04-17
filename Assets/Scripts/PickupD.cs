using UnityEngine;
using UnityEngine.InputSystem;

public class PickupD : MonoBehaviour
{
    public GameObject scissors;
    private bool isGrabbing = false;
    public InputActionReference trigger_input_action_reference;
    float trigger_value;

    void Update()
    {
        trigger_value = trigger_input_action_reference.action.ReadValue<float>();
        print(trigger_value);
        if(trigger_value==1 && isGrabbing)
        {
            transform.SetParent(scissors.transform);
        }
        else{
            transform.SetParent(null);
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
