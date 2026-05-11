using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSetup : MonoBehaviour
{
    private void Start()
    {
        PlayerInput input = GetComponent<PlayerInput>();

        GameManager.Instance.AssignPlayerInput(input);
    }
}