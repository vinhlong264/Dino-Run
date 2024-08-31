using UnityEngine;

public class TrapSpecial : Trap
{
    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }
}
