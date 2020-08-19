using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGiantKeyboard : MonoBehaviour
{
    public GameObject keyboardPlatform;

    public ThreeDigitCodePuzzle puzzle1;
    public InputWhiteboard puzzle2;

    public PuzzleThree puzzle3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzle1.solved && puzzle2.solved && puzzle3.solved) {
            keyboardPlatform.SetActive(true);
        }
    }
}
