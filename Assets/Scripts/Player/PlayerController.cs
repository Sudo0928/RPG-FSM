using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInputs PlayerInput { get; private set; }
    public PlayerInputs.PlayerActions PlayerActions { get; private set; }

    private void Awake()
    {
        PlayerInput = new PlayerInputs();
        PlayerActions = PlayerInput.Player;
    }

    private void OnEnable()
    {
        PlayerInput.Enable();
    }

    private void OnDisable()
    {
        PlayerInput.Disable();
    }
}
