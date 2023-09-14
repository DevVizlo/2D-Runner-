using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMover _mover;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _mover.MoveUp();
        }

        if (Input.GetKey(KeyCode.S))
        {
            _mover.MoveDown();
        }
    }
}
