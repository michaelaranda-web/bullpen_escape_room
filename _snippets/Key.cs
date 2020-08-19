using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{
    public GiantKeyboard keyboard;
    public int positionInSequence;
    
    public string keyValue;

    public string hiddenKeyValue;

    private bool matSetToGreen = false;

    void Start() {
        TMP_Text keyValueDisplay = transform.Find("Text (TMP)").GetComponent<TMP_Text>();
            
        keyValueDisplay.text = keyValue;
    }

    void Update() {
        if (keyboard != null && hiddenKeyValue != null && keyboard.playerKeySequence[positionInSequence] == hiddenKeyValue) {
            Component[] renderers = this.GetComponentsInChildren<Renderer>();

            foreach (Renderer renderer in renderers) { 
                renderer.material.SetColor("_Color", Color.green); 
            }

            matSetToGreen = true;
        } else {
            if (matSetToGreen) {
                Component[] renderers = this.GetComponentsInChildren<Renderer>();

                foreach (Renderer renderer in renderers) { 
                    renderer.material.SetColor("_Color", Color.white); 
                }
            }
        }
    }
}
