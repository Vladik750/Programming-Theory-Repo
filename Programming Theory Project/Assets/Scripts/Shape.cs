using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    protected string shapeName { get { return shapeName; } set { shapeName = value; } }
    public TextMeshProUGUI shapeText;

    //Polymorphism
    public void OnMouseDown()
    {
       shapeText.SetText(shapeName + " was clicked.");
    }
}
