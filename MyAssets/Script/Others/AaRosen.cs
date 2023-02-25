using Godot;
using System;

public class AaRosen : Sprite
{
    public void _Start(){
        var tween = CreateTween();
		tween.TweenProperty(this, "position", new Vector2(120,80), 0.7f);
        tween.TweenInterval(1.55f);
        tween.TweenProperty(this, "position", new Vector2(370,210), 0.7f);
		tween.Connect("finished", this, nameof(Kill));
    }
    private void Kill(){ 
        this.QueueFree();
    }
}
