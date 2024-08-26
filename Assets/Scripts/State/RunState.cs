using UnityEngine;

public class RunState : GroundState
{
    public RunState(Dino _dino, DinoStateManager _stateManager) : base(_dino, _stateManager)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Dino.anim.SetBool("Run", true);
        Debug.Log("Enter RunState");
    }
    public override void Update()
    {
        base.Update();
        Dino.setVelocity(Dino.moveSpeed, Dino.rb.velocity.y);
    }
    public override void Exit()
    {
        base.Exit();
        Dino.anim.SetBool("Run", false);
        Debug.Log("Exit RunState");
    }


}
