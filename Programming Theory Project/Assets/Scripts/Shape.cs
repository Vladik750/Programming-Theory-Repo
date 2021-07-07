using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    public TextMeshProUGUI shapeText;

    //Inheritance
    public void OnMouseDown()
    {
       shapeText.SetText(shapeName + " was clicked.");
    }
}
