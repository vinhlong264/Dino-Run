using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundState : DinoState
{
    
    public GroundState(Dino _dino, DinoStateManager _stateManager) : base(_dino, _stateManager)
    {
    }

    public override void Enter()
    {

    }

    public override void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Dino.isGroundDetected())
        {
            stateManager.changeState(Dino._jumpState);
        }
    }

    public override void Exit()
    {

    }


}