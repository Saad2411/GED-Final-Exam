using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker invoker;
    private Movement movement;

    private ICommand _turnLeft, _turnRight, _jumpUp;

    void Start()
    {
        _turnLeft = new MoveLeftCommand(movement);
        _turnRight = new MoveRightCommand(movement);
        _jumpUp = new JumpCommand(movement);
    }

    void Update()
    {
        //if the player inputs left or right, execute the command to move left or right
        //if the player inputs jump, execute the command to jump
    }
}
