using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    [SerializeField] List<Transform> map = new List<Transform>();
    [SerializeField] int index;
    [SerializeField] float limitSpawn;
    [SerializeField] float currentSpawn;
    [SerializeField] float respawnDis;
    [SerializeField] Transform Player;

    private void FixedUpdate()
    {
        if(Player == null) return;


        if (map.Count > 0)
        {
            if (getDistance(map[index]) < limitSpawn) return;

            Vector3 pos = map[index].position;
            pos.x += respawnDis;
            map[index].position = pos;
            index++;

            if (index >= map.Count)
            {
                index = 0;
            }
        }
    }

    float getDistance(Transform target)
    {
        currentSpawn = Player.transform.position.x - target.position.x;

        return currentSpawn;
    }
}
