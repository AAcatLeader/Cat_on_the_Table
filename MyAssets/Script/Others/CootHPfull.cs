using Godot;
using System;

public class CootHPfull : Sprite
{
    public void _Start(){
        GetNode<AnimationPlayer>("bbAni").Play("bbAni");
        var tween = CreateTween();
		tween.TweenProperty(this, "modulate", new Color(1, 1, 1, 1), 1f);
        tween.Parallel().TweenProperty(this, "scale", new Vector2(1,1), 1f);
    }

    public void _Hide(){
        var tween = CreateTween();
        tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 3f);
        tween.Parallel().TweenProperty(this, "scale", new Vector2(20,20), 1f);
        tween.Parallel().TweenProperty(this, "position", new Vector2(120,-70), 0.7f);
    }

    public void _Show(){
        var tween = CreateTween();
        tween.TweenProperty(this, "modulate", new Color(1, 1, 1, 1), 0.3f);
        tween.Parallel().TweenProperty(this, "scale", new Vector2(1,1), 0.3f);
        tween.Parallel().TweenProperty(this, "position", new Vector2(120,80), 0.3f);
    }
}
