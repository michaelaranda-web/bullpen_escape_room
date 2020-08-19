using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GiantKeyboard : MonoBehaviour
{
    
    private bool enter = false;

    private string[] correctKeySequence = {"RightShift", "Slash", "Period", "Comma", "M", "N", "B", "G", "T", "Alpha5", "Alpha4", "Alpha3", "Alpha2", "Alpha1"};

    public string[] playerKeySequence = new string[20];
    private int numCorrectKeysPressedInSequence = 0;

    public bool solved;

    // UnityEvent m_MyEvent;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            enter = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enter) {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                validateKeyPress(KeyCode.RightShift.ToString());
            }
        }
    }

    void OnGUI()
    {
        if (enter)
        {
            if (Event.current.type == EventType.KeyDown && Event.current.keyCode.ToString() != "None" && Event.current.keyCode.ToString() != "RightShift") {
                validateKeyPress(Event.current.keyCode.ToString());
            }
        }
    }

    public void ShowKeyboard(bool value) {
        this.gameObject.SetActive(value);
    }

    private void validateKeyPress(string keyPressed) {
        if (keyPressed == null) {
            return;
        }

        playerKeySequence[numCorrectKeysPressedInSequence] = keyPressed;

        if (playerKeySequence[numCorrectKeysPressedInSequence] == correctKeySequence[numCorrectKeysPressedInSequence]) {
            numCorrectKeysPressedInSequence = numCorrectKeysPressedInSequence + 1;
        } else {
            // flash red, then unlight all green keys and reset keyboard to original state

            numCorrectKeysPressedInSequence = 0;
            playerKeySequence = new string[20];
        }

        if (numCorrectKeysPressedInSequence == correctKeySequence.Length) {
            //win!
            solved = true;

            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.green); 
            }
        }
    }
}
