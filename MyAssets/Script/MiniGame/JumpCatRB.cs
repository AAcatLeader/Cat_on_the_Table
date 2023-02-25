using Godot;
using System;

public class JumpCatRB : RigidBody2D
{
    public bool grab, letsGo;

    testText tt;

    public override void _Ready(){

        tt = GetNode<testText>("%testText");
    }
    
     public override void _Input(InputEvent ev){
        if(ev is InputEventMouseButton ev2){
            if (ev2.ButtonIndex == 1 && !ev2.Pressed){
                grab = false;
            }
        }
    }

    private void _on_JumpCatRB_input_event(Node vp,InputEvent ev,int i){
        if(Input.IsActionPressed("click") && letsGo){
            grab = true;
        }
    }

    public override void _Process(float delta){
        if (GlobalPosition.x > 190 && letsGo){
            tt.passed = true;
            letsGo = false;
        }

        if (grab){
            GlobalPosition = Lerp(GlobalPosition, GetGlobalMousePosition(),25 * delta);
            Mass = 0;
        }else{
            Mass = 1;
        }
    }

    float Lerp(float firstFloat, float secondFloat, float by){
        return firstFloat * (1 - by) + secondFloat * by;
    }
    Vector2 Lerp(Vector2 firstVector, Vector2 secondVector, float by){
        float retX = Lerp(firstVector.x, secondVector.x, by);
        float retY = Lerp(firstVector.y, secondVector.y, by);
        return new Vector2(retX, retY);
    }
    
    public void _Start(){

    }

    public void _End(){
        
    }
}
