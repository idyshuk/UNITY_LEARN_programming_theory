using UnityEngine;

public class Shape : MonoBehaviour
{
    // ENCAPSULATION: Using properties for name and color
    public string Name { get; private set; }
    public Color ShapeColor { get; private set; }

    // Setters to allow controlled modifications
    public void SetName(string name) => Name = name; // ENCAPSULATION
    public void SetColor(Color color) => ShapeColor = color; // ENCAPSULATION

    // POLYMORPHISM: Virtual method for overriding in child classes
    public virtual void DisplayText()
    {
        Debug.Log($"You clicked on a shape: {Name}");
    }

    // Helper method to visually set the color
    public void ApplyColor()
    {
        GetComponent<Renderer>().material.color = ShapeColor;
    }
}
