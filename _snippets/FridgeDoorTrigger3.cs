using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoorTrigger3 : MonoBehaviour
{
    public OpenableDoor3 door;
    public string triggerText;
    public bool triggered = false;

    bool enter = false;

    void Update() {
        if (Input.GetMouseButtonDown(0) && enter)
        {
            door.DoorTriggered();
        }
    }

    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }

    // Deactivate the Main function when Player exit the trigger area
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = false;
            triggered = false;
        }
    }

    // Display a simple info message when player is inside the trigger area
    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), triggerText);
        }
    }
}