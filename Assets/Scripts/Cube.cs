using UnityEngine;

// INHERITENCE
public class Cube : Shape
{

    new private void Start()
    {
        color = Color.red;
        base.Start();
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        WriteShapeText("I am a Cube");
    }

}
