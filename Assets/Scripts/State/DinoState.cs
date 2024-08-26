public abstract class DinoState
{
    protected Dino Dino;
    protected DinoStateManager stateManager;

    protected DinoState(Dino _dino, DinoStateManager _stateManager)
    {
        Dino = _dino;
        this.stateManager = _stateManager;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();

}
