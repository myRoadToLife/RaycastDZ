using UnityEngine;

public class Player : MonoBehaviour
{
    private IBehavior _behavior;

    public void SetBehavior(IBehavior behavior)
    {
        _behavior = behavior;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            _behavior.Cast(ray);
        }
    }
}

   
