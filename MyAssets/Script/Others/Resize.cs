using Godot;
using System;

public class Resize : Sprite
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";


	Sprite djTable;
	public Dj djs;

	//TODO Show DJ table and move music scrit to dj table

	public override void _Ready()
    {
        djTable = this.GetNode<Sprite>("%Dj");
		
    }

	private void _on_TextureButton_pressed()
	{
		OS.WindowResizable = false;
		var tween = CreateTween();
		tween.TweenProperty(this, "modulate", new Color(0, 0, 0, 0), 1f);
		tween.Parallel().TweenProperty(this, "scale", new Vector2(3,3), 1f);
		tween.Connect("finished", this, nameof(Kill));
		GetNode<TextureButton>("Play").QueueFree();

		//play music when done
	}
	private void Kill(){ // I still dont know how tf this works
		GD.Print("Done");
		djTable.Show();
		djTable.Call("_Start");
		this.QueueFree();
	}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.

}



