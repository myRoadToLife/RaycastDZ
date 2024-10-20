using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField]private Renderer _renderer;

    private void OnMouseEnter()
    {
        _renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        _renderer.material.color = Color.white;
    }
}
