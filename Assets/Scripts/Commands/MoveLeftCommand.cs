using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    private Movement _movement;

    public MoveLeftCommand(Movement movement)
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
