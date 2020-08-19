using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stan : MonoBehaviour
{
    public GiantKeyboard keyboard;

    // Update is called once per frame
    void Update()
    {
        if (keyboard.solved) {
            GameObject speechBubble = transform.Find("Text (TMP)").gameObject;
            
            speechBubble.SetActive(true);
        }
    }
}
