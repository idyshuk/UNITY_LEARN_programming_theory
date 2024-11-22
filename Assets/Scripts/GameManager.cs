using UnityEngine;

public class GameManager : MonoBehaviour
{
    private ShapeManager shapeManager;

    private void Start()
    {
        shapeManager = GetComponent<ShapeManager>();
        shapeManager.InitializeShapes(); // ABSTRACTION
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Shape clickedShape = hit.collider.GetComponent<Shape>();
                if (clickedShape != null)
                {
                    shapeManager.HandleShapeClick(clickedShape); // ABSTRACTION
                }
            }
        }
    }
}