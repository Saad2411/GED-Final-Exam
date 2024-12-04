using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : ICommand
{
    private Movement _movement;

    public JumpCommand(Movement movement)
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
