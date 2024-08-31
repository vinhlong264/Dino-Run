using UnityEngine;

public class DeathState : DinoState
{
    public DeathState(Dino _dino, DinoStateManager _stateManager) : base(_dino, _stateManager)
    {
    }

    public override void Enter()
    {
        Dino.anim.SetBool("Death", true);
        Dino.rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        Dino.cd.enabled = false;
        Dino.StateTimer = 0.75f;
    }
    public override void Update()
    {
        if (Dino.StateTimer <= 0f)
        {
            Dino.rb.bodyType = RigidbodyType2D.Static;
        }
    }

    public override void Exit()
    {
        Dino.anim.SetBool("Death", false);
    }

}
