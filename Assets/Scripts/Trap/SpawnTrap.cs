using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrap : MonoBehaviour
{
    public GameObject trap;
    public bool isTime;
    public Dino dino;
    void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            if (Random.Range(0, 100) <= 50)
            {
                isTime = true;
            }


            if (isTime)
            {
                GameObject obj = Instantiate(trap, new Vector2(dino.transform.position.x + 5f, -1), Quaternion.identity);
                isTime = false;
            }
            yield return new WaitForSeconds(5);
        }
    }
    
}
