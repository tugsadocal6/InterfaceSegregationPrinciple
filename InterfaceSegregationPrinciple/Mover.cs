﻿using UnityEngine;

public class Mover
{
    public void Move(Transform target, Vector3 movement)
    {
        var moveable = target.GetComponent<IMoveable>();
        if (moveable == null) { return; }
        moveable.Move(movement);
    }
}