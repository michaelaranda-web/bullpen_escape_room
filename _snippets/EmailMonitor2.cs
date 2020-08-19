using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailMonitor2 : MonoBehaviour
{
    public GameObject panel = null;

    public InputWhiteboard puzzle;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && puzzle.solved) {
            panel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && puzzle.solved) {
            panel.SetActive(false);
        }
    }

    void Update() {
        if (puzzle.solved) {
            GameObject screen = transform.Find("screen").gameObject;
            GameObject browser_window = transform.Find("browser_window").gameObject;
            
            screen.GetComponent<Renderer>().material.SetColor("_Color", new Color(r: 203, g: 255, b: 255)); 
            browser_window.SetActive(true);
        }
    }
}
