using Godot;
using System;

public class TimeBall : Sprite
{
    public void _Start(){
        GetNode<AnimationPlayer>("tbAni").Play("TimeBall");
    }
}
