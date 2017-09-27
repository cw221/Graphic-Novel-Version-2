using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightButton : MonoBehaviour {

	// Use this for initialization
	public void ChangeHighlight(Button newButton)
    {
        if(newButton != null)
        {
            newButton.Select();
        }
    }
}
