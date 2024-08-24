using UnityEngine;

public class IdleState : GroundState
{
    public IdleState(Dino _dino, DinoStateManager _stateManager) : base(_dino, _stateManager)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Dino.anim.SetBool("Idle", true);
        Debug.Log("Enter IdleState");

        Dino.StateTimer = 2f;
    }
    public override void Update()
    {
        base.Update();
        if(Dino.StateTimer < 0)
        {
            stateManager.changeState(Dino._runState);
        }
    }
    public override void Exit()
    {
        base.Exit();
        Dino.anim.SetBool("Idle", false);
        Debug.Log("Exit IdleState");
    }
}
