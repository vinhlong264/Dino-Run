using UnityEngine;

public class TrapSpecial : Trap
{
    [SerializeField] protected Transform attackCheck;   
    [SerializeField] protected float attackDistance;
    [SerializeField] protected LayerMask mask;
    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
        if(attackCheck == null)
        {
            attackCheck = null;
        }
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }

    protected RaycastHit2D isEntityDetected() => Physics2D.Raycast(attackCheck.position, Vector2.left, attackDistance, mask);

    protected void OnDrawGizmos()
    {
        Gizmos.DrawLine(attackCheck.position, new Vector3(attackCheck.position.x - attackDistance, attackCheck.position.y, attackCheck.position.z));
    }
}
