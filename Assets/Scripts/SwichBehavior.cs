using UnityEngine;

public class SwichBehavior : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.SetBehavior(new Detonator());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _player.SetBehavior(new Detonator());
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _player.SetBehavior(new DragDrop());
        }
    }
}