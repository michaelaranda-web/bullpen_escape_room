using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputMonitor : MonoBehaviour
{
    public GameObject monitor = null;
    public GameObject OpenPanel = null;
    public string correctAnswer;
    public string currentInput;

    private bool _isInsideTrigger = false;
    private bool _isActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            _isInsideTrigger= true;
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") {
            _isInsideTrigger= false;
            SetPanelText("Enter a digit");
            OpenPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_isInsideTrigger) {
            if(Input.GetKey("1")) {
                SetMonitorText("1");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("2")) {
                SetMonitorText("2");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("3")) {
                SetMonitorText("3");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("4")) {
                SetMonitorText("4");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("5")) {
                SetMonitorText("5");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("6")) {
                SetMonitorText("6");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("7")) {
                SetMonitorText("7");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("8")) {
                SetMonitorText("8");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("9")) {
                SetMonitorText("9");
                OpenPanel.SetActive(false);
            } else if(Input.GetKey("0")) {
                SetMonitorText("0");
                OpenPanel.SetActive(false);
            } 
        }
    }

    private void SetPanelText(string text) {
        Text panelText = OpenPanel.transform.Find("Text").GetComponent<Text>();

        if (panelText != null) {
            panelText.text = text;
        }
    }

    private void SetMonitorText(string text) {
        TMP_Text displayedText = monitor.transform.Find("Text (TMP)").GetComponent<TMP_Text>();

        if (displayedText != null) {
            displayedText.text = text;
            currentInput = text;
        }
    }
}
