using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThreeDigitCodeInput : MonoBehaviour
{
    public string currentInput;

    string triggerText = "Enter a digit";

    bool enter = false;

    void Update() {
        if (enter) {
            if (Input.GetKey("1")) {
                SetDigit("1");
            } else if(Input.GetKey("2")) {
                SetDigit("2");
            } else if(Input.GetKey("3")) {
                SetDigit("3");
            } else if(Input.GetKey("4")) {
                SetDigit("4");
            } else if(Input.GetKey("5")) {
                SetDigit("5");
            } else if(Input.GetKey("6")) {
                SetDigit("6");
            } else if(Input.GetKey("7")) {
                SetDigit("7");
            } else if(Input.GetKey("8")) {
                SetDigit("8");
            } else if(Input.GetKey("9")) {
                SetDigit("9");
            } else if(Input.GetKey("0")) {
                SetDigit("0");
            } 
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

    private void SetDigit(string text) {
        TMP_Text displayedText = transform.Find("Text (TMP)").GetComponent<TMP_Text>();

        if (displayedText != null) {
            displayedText.text = text;
            currentInput = text;
        }
    }
}
