using UnityEngine;

public class Circle : Shape // INHERITANCE
{
    private void Start()
    {
        SetName("Circle"); // ENCAPSULATION
        SetColor(Color.red); // ENCAPSULATION
        ApplyColor();
    }
    
    // POLYMORPHISM: Overriding base class method
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("You clicked on the Circle!");
    }
}