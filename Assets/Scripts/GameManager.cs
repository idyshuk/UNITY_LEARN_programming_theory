using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text helloText;
    private ShapeManager shapeManager;

    private void Start()
    {
        helloText.text = "Hello " + PlayerPrefs.GetString("PlayerName", "NONAME");
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