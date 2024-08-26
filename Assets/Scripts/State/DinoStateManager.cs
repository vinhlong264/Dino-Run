public class DinoStateManager 
{
    public DinoState currentState { get; private set; }

    public void Initialization(DinoState _state)
    {
        currentState = _state;
        currentState.Enter();
    }

    public void changeState(DinoState _newState)
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }
}
