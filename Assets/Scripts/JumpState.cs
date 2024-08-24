using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : DinoState
{
    public JumpState(Dino _dino, DinoStateManager _stateManager) : base(_dino, _stateManager)
    {
    }

    public override void Enter()
    {
        Dino.anim.SetBool("Jump", true);

        Dino.setVelocity(5, 20);
        Dino.StateTimer = 1f;

    }

    public override void Update()
    {
        if(Dino.StateTimer < 0)
        {
            stateManager.changeState(Dino._idleState);
        }
    }

    public override void Exit()
    {
        Dino.anim.SetBool("Jump", false);
    }


}
