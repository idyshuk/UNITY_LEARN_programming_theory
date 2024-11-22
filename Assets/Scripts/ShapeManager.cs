using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    private List<Shape> shapes = new List<Shape>();

    // ABSTRACTION: Higher-level method to initialize shapes
    public void InitializeShapes()
    {
        Shape[] foundShapes = FindObjectsOfType<Shape>();

        foreach (Shape shape in foundShapes)
        {
            shapes.Add(shape);
        }
    }

    // ABSTRACTION: Higher-level method to handle clicks
    public void HandleShapeClick(Shape clickedShape)
    {
        clickedShape.DisplayText();
        Debug.Log($"Shape {clickedShape.Name} has {clickedShape.ShapeColor} color");
    }
}