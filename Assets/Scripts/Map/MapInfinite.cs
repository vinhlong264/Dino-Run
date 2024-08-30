using UnityEngine;

public class MapInfinite : MonoBehaviour
{
    [SerializeField] protected float currentDis;
    [SerializeField] protected Transform target;
    [SerializeField] protected float respawnDis;
    [SerializeField] protected float limitDis;

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {
        Spawning();
    }


    protected virtual void Spawning()
    {
        if (getDistance() < limitDis)
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
