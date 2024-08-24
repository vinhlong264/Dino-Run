using UnityEngine;

public class Dino : MonoBehaviour
{
    #region Component
    public Animator anim {  get; private set; }
    public Rigidbody2D rb { get; private set; }
    #endregion

    #region State
    public DinoStateManager stateManager { get; private set; }
    public IdleState _idleState {  get; private set; }
    public RunState _runState { get; private set; }
    public JumpState _jumpState { get; private set; }

    #endregion

    public float StateTimer;

    [Header("Move info")]
    public float moveSpeed;
    public bool isGround;
    public bool canJump;

    [Header("Colision info")]
    [SerializeField] private Transform Ground;
    [SerializeField] private float grounDistance;
    [SerializeField] private LayerMask WhatIsMask;

    private void Awake()
    {
        stateManager = new DinoStateManager();
        _idleState = new IdleState(this, stateManager);
        _runState = new RunState(this, stateManager);
        _jumpState = new JumpState(this, stateManager);
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        stateManager.Initialization(_idleState);
    }

    private void Update()
    {
        stateManager.currentState.Update();
        StateTimer -= Time.deltaTime;
        isGround = isGroundDetected();
    }


    public void setVelocity(float x , float y)
    {
        rb.velocity = new Vector2 (x, y);
    }

    public RaycastHit2D isGroundDetected() => Physics2D.Raycast(Ground.position, Vector2.down, WhatIsMask);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Ground.position, new Vector3(Ground.position.x, Ground.position.y - grounDistance, Ground.position.z));
    }

}
