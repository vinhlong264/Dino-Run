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

        Dino.setVelocity(Dino.rb.velocity.x, 15);
        Dino.StateTimer = 0.75f;

    }

    public override void Update()
    {
        if(Dino.StateTimer < 0)
        {
            stateManager.changeState(Dino._runState);
        }
    }

    public override void Exit()
    {
        Dino.anim.SetBool("Jump", false);
    }


}
