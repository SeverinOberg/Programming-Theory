using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour 
{
    [SerializeField] private TextMeshProUGUI shapeText;
    // ENCAPSULATION
    public Color color { get; protected set; }

    protected void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material.color = color;
    }

    // POLYMORPHISM
    public virtual void DisplayText()
    {
        WriteShapeText("I am a Shape");
    }

    // ABSTRACTION
    protected void WriteShapeText(string text)
    {
        shapeText.text = text;
    }
    

}
