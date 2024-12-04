using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    private Movement _movement;

    public MoveRightCommand(Movement movement)
    {
        _movement = movement;
    }

    public void Execute()
    {

    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }
}
