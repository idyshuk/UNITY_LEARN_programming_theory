using UnityEngine;

public class Square : Shape // INHERITANCE
{
    
    private void Start()
    {
        SetName("Square"); // ENCAPSULATION
        SetColor(Color.blue); // ENCAPSULATION
        ApplyColor();
    }

    
    // POLYMORPHISM: Overriding base class method
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("You clicked on the Square!");
    }
}
