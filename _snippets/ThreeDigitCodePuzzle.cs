using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeDigitCodePuzzle : MonoBehaviour
{
    public ThreeDigitCodeInput firstDigitInput;
    public ThreeDigitCodeInput secondDigitInput;
    public ThreeDigitCodeInput thirdDigitInput;

    public string answerOne;
    public string answerTwo;
    public string answerThree;

    public bool solved = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string inputOne = firstDigitInput.GetComponent<ThreeDigitCodeInput>().currentInput;
        string inputTwo = secondDigitInput.GetComponent<ThreeDigitCodeInput>().currentInput;
        string inputThree = thirdDigitInput.GetComponent<ThreeDigitCodeInput>().currentInput;

        bool firstDigitCorrect = inputOne == answerOne;
        bool secondDigitCorrect = inputTwo == answerTwo;
        bool thirdDigitCorrect = inputThree == answerThree;

        if (firstDigitCorrect && secondDigitCorrect && thirdDigitCorrect) {
            solved = true;

            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.green); 
            }
        }
    }
}
