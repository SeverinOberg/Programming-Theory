using UnityEngine;

// INHERITENCE
public class Sphere : Shape 
{

    new private void Start()
    {
        color = Color.yellow;
        base.Start();
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        WriteShapeText("I am a Sphere");
    }

}
