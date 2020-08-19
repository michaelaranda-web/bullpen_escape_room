using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableDoor : MonoBehaviour
{
    public GameObject sodaCan1;
    public GameObject sodaCan2;
    public GameObject sodaCan3;
    public GameObject sodaCan4;
    public GameObject sodaCan5;
    public GameObject sodaCan6;

    // Smoothly open a door
    public float doorOpenAngle = 90.0f; //Set either positive or negative number to open the door inwards or outwards
    public float openSpeed = 2.0f; //Increasing this value will make the door open faster

    bool open = false;
    bool openingOrClosing = false;

    float defaultRotationAngle;
    float currentRotationAngle;
    float openTime = 0;

    int stepForShowingCans = 0;

    void Start()
    {
        defaultRotationAngle = transform.localEulerAngles.y;
        currentRotationAngle = transform.localEulerAngles.y;
    }

    // Main function
    void Update()
    {
        if (openTime < 1) {
            openTime += Time.deltaTime * openSpeed;
        } else {
            openingOrClosing = false;
        }
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Mathf.LerpAngle(currentRotationAngle, defaultRotationAngle + (open ? doorOpenAngle : 0), openTime), transform.localEulerAngles.z);
    }

    public void DoorTriggered() {
        if (openingOrClosing == false) {
            if (stepForShowingCans == 0) {
                sodaCan3.SetActive(false);
                sodaCan4.SetActive(false);
                sodaCan5.SetActive(false);
                sodaCan6.SetActive(false);

                stepForShowingCans++;
            } else if (stepForShowingCans == 2) {
                sodaCan3.SetActive(true);
                sodaCan4.SetActive(true);
                stepForShowingCans++;
            } else if (stepForShowingCans == 4) {
                sodaCan5.SetActive(true);
                sodaCan6.SetActive(true);
                stepForShowingCans++;
            } else if (stepForShowingCans == 5) {
                stepForShowingCans = 0;
            } else {
                stepForShowingCans++;
            }

            openingOrClosing= true;
            open = !open;
            currentRotationAngle = transform.localEulerAngles.y;
            openTime = 0;
        }
    }
}