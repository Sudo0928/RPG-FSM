using UnityEngine;

public class PlayerFallState : PlayerAirborneState
{
    public PlayerFallState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.Player.AnimationData.FallParameterHash);
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Player.AnimationData.FallParameterHash);
    }

    public override void Update()
    {
        base.Update();

        if (stateMachine.Player.Controller.isGrounded)
        {
            stateMachine.ChangeState(stateMachine.IdleState);
            return;
        }
    }
}
