using Godot;
using System;

public class Dj : Sprite
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    { 
        GetNode<AnimationPlayer>("DJani").Play("TernTable");
    }

    public void _Start(){
        var tween = CreateTween();
		tween.TweenProperty(this, "modulate", new Color(1, 1, 1, 1), 1f);
    }


    public void _End(){
        var tween = CreateTween();
		tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 1f);
		tween.Parallel().TweenProperty(this, "scale", new Vector2(3,3), 1f);
		tween.Connect("finished", this, nameof(Kill));
    }
    private void Kill(){ 
        this.QueueFree();
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
