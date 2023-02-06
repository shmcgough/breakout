using Godot;
using System;

public partial class start_screen : Control
{
	SceneManager sceneManager;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public override void _Input(InputEvent @event)
	{

		if (@event is InputEventKey eventKey)
		{
			if (eventKey.Keycode == Key.Space)
			{
				sceneManager = GetNode<SceneManager>("/root/SceneManager");
				sceneManager.GoToScene("res://game.tscn");
			}
		}
	}
}
