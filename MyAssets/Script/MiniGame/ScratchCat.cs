using Godot;
using System;

public class ScratchCat : Sprite
{
    public bool grab, letsGo;

    float mouseStartPos = 90000f, mouseDiff;

    testText tt;

    public override void _Ready()
    {
        tt = GetNode<testText>("%testText");
    }

    public override void _Input(InputEvent ev){
        if(ev is InputEventMouseButton ev2){
            if (ev2.ButtonIndex == 1 && !ev2.Pressed){
                grab = false;
            }
        }
    }

    private void _on_Area2D_input_event(Node vp,InputEvent ev,int i){
        if(Input.IsActionPressed("click") && letsGo){
            grab = true;
        }
    }

    public override void _Process(float delta){
        if (GlobalPosition.y > 135 && letsGo){
            tt.passed = true;
            letsGo = false;
        }

        if (grab){
            if(mouseStartPos == 90000f){
            mouseStartPos = GetGlobalMousePosition().y;
        }
        if (GetGlobalMousePosition().y > mouseStartPos){
            mouseDiff = GetGlobalMousePosition().y - mouseStartPos;
            mouseStartPos = GetGlobalMousePosition().y;
        }
            GlobalPosition = new Vector2(GlobalPosition.x,GlobalPosition.y + mouseDiff);
        }
    }

}
