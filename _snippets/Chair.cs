using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public InputMonitor monitorOneObject;
    public InputMonitor monitorTwoObject;
    public InputMonitor monitorThreeObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string inputOne = monitorOneObject.GetComponent<InputMonitor>().currentInput;
        string answerOne = monitorOneObject.GetComponent<InputMonitor>().correctAnswer;
        string inputTwo = monitorTwoObject.GetComponent<InputMonitor>().currentInput;
        string answerTwo = monitorTwoObject.GetComponent<InputMonitor>().correctAnswer;
        string inputThree = monitorThreeObject.GetComponent<InputMonitor>().currentInput;
        string answerThree = monitorThreeObject.GetComponent<InputMonitor>().correctAnswer;

        bool monitorOneCorrect = inputOne == answerOne;
        bool monitorTwoCorrect = inputTwo == answerTwo;
        bool monitorThreeCorrect = inputThree == answerThree;

        if (monitorOneCorrect && monitorTwoCorrect && monitorThreeCorrect) {
            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.green); 
            }
        }
    }
}
