using UnityEngine;

public class Player : MonoBehaviour
{
    private const int LeftMousClick = 0;

    private IBehavior _behavior;

    public void SetBehavior(IBehavior behavior)
    {
        _behavior = behavior;
    }

    private void Update()
    {
        if (Input.GetMouseButton(LeftMousClick))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            _behavior.Cast(ray);
        }
    }
}

   
