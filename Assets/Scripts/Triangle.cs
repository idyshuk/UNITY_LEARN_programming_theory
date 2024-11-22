using UnityEngine;

public class Triangle : Shape // INHERITANCE
{
    private void Start()
    {
        SetName("Triangle"); // ENCAPSULATION
        SetColor(Color.green); // ENCAPSULATION
        ApplyColor();
    }
    
    // POLYMORPHISM: Overriding base class method
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("You clicked on the Triangle!");
    }
}