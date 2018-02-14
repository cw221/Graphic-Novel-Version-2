using UnityEngine;
using System.Collections;

public class Spriteclicked : MonoBehaviour
{
    public Sprite spriteChange;
    public Sprite spriteOriginal;
    bool Selected = false;

    void OnMouseDown()
    {
        if (!Selected)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteChange;
            GameObject canvas = GameObject.Find("Canvas");
            var newPosition = new Vector3(0,-250,0);
            GameObject instance = Instantiate(Resources.Load("Text Box"), newPosition, transform.rotation) as GameObject;
            instance.transform.SetParent(canvas.transform);
            Selected = true;
        } else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spriteOriginal;
            Selected = false;
        }
    } 
        
}