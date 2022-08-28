using UnityEngine;

// INHERITENCE
public class Cylinder : Shape
{

    new private void Start()
    {
        color = Color.green;
        base.Start();
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        WriteShapeText("I am a Cylinder");
    }

}
