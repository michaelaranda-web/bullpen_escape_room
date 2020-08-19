using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputWhiteboard : MonoBehaviour
{
    public GameObject inputFieldCanvas = null;
    public TMP_InputField inputField = null;
    public string correctAnswer;
    public string currentInput;

    public bool solved;
    
    private bool _isActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !solved) {
            _isActive = true;
            inputFieldCanvas.SetActive(true);

            inputField.Select();
            inputField.ActivateInputField();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && !solved) {
            _isActive = false;
            inputFieldCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isActive) {
            if (Input.GetKey("return") || Input.GetKey("enter")) {
                currentInput = inputField.text.ToLower();

                if (currentInput == correctAnswer) {
                    solved = true;

                    Component[] renderers = this.GetComponentsInChildren<Renderer>();

                    foreach (Renderer renderer in renderers) { 
                        renderer.material.SetColor("_Color", Color.green); 
                    }
                }

                inputFieldCanvas.SetActive(false);
            }
        }
    }
}
