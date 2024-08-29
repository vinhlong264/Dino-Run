using UnityEngine;

public class MapInfinite : MonoBehaviour
{
   [SerializeField] private float currentDis;
   [SerializeField] private Transform target;
   [SerializeField] private float respawnDis;
   [SerializeField] private float limitDis;

    protected virtual void FixedUpdate()
    {
        Spawning();
    }


    protected virtual void Spawning()
    {
        if(getDistance() < limitDis)
        {
            return;
        }

        Vector3 pos = transform.position;
        pos.x += respawnDis;
        transform.position = pos;
    }

    protected virtual float getDistance()
    {
        currentDis = target.transform.position.x - transform.position.x;
        return currentDis;
    }
}
