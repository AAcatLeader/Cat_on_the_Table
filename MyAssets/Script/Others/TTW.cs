using Godot;
using System;

public class TTW : Sprite
{
    public void _Pull(){
        this.Modulate = new Color(1, 1, 1, 1);
        GetNode<AnimationPlayer>("TreeTewWun").Play("Pull");
        var tween = CreateTween();
        tween.TweenInterval(1.7f);
        tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 1f);
    }
    public void _Swing(){
        this.Modulate = new Color(1, 1, 1, 1);
        GetNode<AnimationPlayer>("TreeTewWun").Play("Swing");
        var tween = CreateTween();
        tween.TweenInterval(1.7f);
        tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 1f);
    }
    public void _Jump(){
        this.Modulate = new Color(1, 1, 1, 1);
        GetNode<AnimationPlayer>("TreeTewWun").Play("Jump");
        var tween = CreateTween();
        tween.TweenInterval(1.7f);
        tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 1f);
    }
}
