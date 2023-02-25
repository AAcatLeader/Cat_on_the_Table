using Godot;
using System;

public class DJwand : Sprite
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    float mouseAngle; 
    private bool grab, museStart;

    // Called when the node enters the scene tree for the first time.
    
    public override void _Input(InputEvent ev){
        if(ev is InputEventMouseButton ev2){
            if (ev2.ButtonIndex == 1 && !ev2.Pressed){
                grab = false;
            }
        }
    }

    private void _on_Area2D_input_event(Node vp,InputEvent ev,int i){
        if(Input.IsActionPressed("click") && !museStart){
            GD.Print("Pull");
            grab = true;
        }
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta){
        if(true){ //GetGlobalMousePosition().x < 208f
            mouseAngle = Mathf.Atan((GetGlobalMousePosition().y-77)/(GetGlobalMousePosition().x-214))-(Mathf.Pi/4);
        }    
        
        if (grab){
            //GlobalRotation = Lerp(GlobalRotation, mouseAngle,25 * delta); //manual implementation
            GlobalRotation = Mathf.Lerp(GlobalRotation, mouseAngle,25 * delta);
        }else if(GlobalRotation < -0.3 && GlobalRotation > -0.5 && !museStart){
            GetParent().GetParent().GetNode<AudioStreamPlayer>("Funk").Play();
            GD.Print(GlobalRotation);
            museStart = true;
            GetParent().Call("_End");
            GetParent().GetParent().GetNode<RichTextLabel>("%testText").Call("_Start");
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
}
