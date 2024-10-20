using UnityEngine;

public class DragDrop : IBehavior
{
    private Camera _camera;
    private Box _draggedBox;

    public DragDrop()
    {
        _camera = Camera.main;
    }

    public void Cast(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity))
        {
            Box box = hitInfo.collider.GetComponent<Box>();

            if (box != null)
            {
                _draggedBox = box;

                UpdatePosition(_draggedBox);
            }
        }
    }

    private void UpdatePosition(Box box)
    {
        Vector3 newMousePosition = GetMouseWorldPosition();

        box.transform.position = new Vector3(newMousePosition.x, newMousePosition.y, box.transform.position.z);
    }

    private Vector3 GetMouseWorldPosition()
    {
        return _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _camera.WorldToScreenPoint(_draggedBox.transform.position).z));
    }
}
