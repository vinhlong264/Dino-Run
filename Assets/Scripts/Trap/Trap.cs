using UnityEngine;

public class Trap : MonoBehaviour
{
    protected float stateDuration;

    protected Animator anim;
    protected virtual void Start()
    {
    }

    
    protected virtual void Update()
    {
        
    }


    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dino"))
        {
            Dino target = collision.GetComponent<Dino>();
            if ((target != null))
            {
                target.Die();
            }
        }
    }
}
