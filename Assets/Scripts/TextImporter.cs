﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextImporter : MonoBehaviour {

    public GameObject textPanel;    //the fancy Random Textbox image
    public Text textBox;            //the actual text box that holds text
    public TextAsset textFile;      //the file to import text
    public int currentLine;
    public int endAtLine;
    public string[] textLines;


	void Start () {

        //parsing the text file. need rework later
        if (textFile != null) 
        {
            textLines = textFile.text.Split('\n');
        }

        //kinda unneeded. useful if only one text file and multiple stop points
        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
	}

	void Update () {

        //what happens at end of text lines
        if (currentLine > endAtLine)
        {
            textPanel.SetActive(false);
        }

        //displaying text. needs rework later
        else
        {
            textBox.text = textLines[currentLine];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                currentLine += 1;
            }
        }
	}
}
