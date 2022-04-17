using UnityEngine;
using UnityEngine.UI;

public class DisplayTextHandler : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick();
        }
    }

    public void OnClick()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.gameObject.TryGetComponent(out Shape shape))
            {
                text.text = shape.DisplayText(); // POLYMORPHISM
            }
        }
    }

}
