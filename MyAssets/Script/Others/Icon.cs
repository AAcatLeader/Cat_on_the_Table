using Godot;
using System;

public class Icon : Sprite
{
    public void _Start(){
        var tween = CreateTween();
		tween.TweenProperty(this, "position", new Vector2(120,80), 1f);
        tween.TweenInterval(1.55f);
        tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 1f);
		tween.Parallel().TweenProperty(this, "scale", new Vector2(3,3), 1f);
		tween.Connect("finished", this, nameof(Kill));
    }
    private void Kill(){ 
        this.QueueFree();
    }
}
