using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                HandleHitAction(hit);
            }
        }
    }

    // ABSTRACTION
    private void HandleHitAction(RaycastHit hit)
    {
        Shape shape = hit.transform.GetComponent<Shape>();
        shape.DisplayText();
    }

}
