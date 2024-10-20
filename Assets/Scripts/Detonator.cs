using UnityEngine;

public class Detonator : IBehavior
{
    private float _explosionRadius = 10f;
    private float _explosionForce = 10f;

    private RaycastHit _hitInfo;

    public void Cast(Ray ray)
    {
        if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity))
        {
            Detonate(hitInfo.point, _explosionRadius, _explosionForce);
        }
    }

    public void Detonate(Vector3 explosionPoint, float explosionRadius, float forse)
    {
        Collider[] targets = Physics.OverlapSphere( _hitInfo.point, _explosionRadius);

        foreach (Collider target in targets)
        {
            Rigidbody rigidbody = target.GetComponent<Rigidbody>();

            if (rigidbody != null)
            {
                Vector3 forceDirection = Random.insideUnitSphere * forse;

                rigidbody.AddForce(forceDirection, ForceMode.Impulse);
            }
        }
    }

}
