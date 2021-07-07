using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    //Encapsulation
    protected string shapeName { get { return shapeName; } set { shapeName = value; } }
    public TextMeshProUGUI shapeText;

    //Polymorphism
    public void OnMouseDown()
    {
       shapeText.SetText(shapeName + " was clicked.");
    }
    //Abstraction, only 10 rows of code used, no code copy-pasting
}
