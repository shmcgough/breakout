using Godot;
using System;

public partial class target : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_target_body_entered(Node2D body)
	{
		CharacterBody2D someNode = GetNode<CharacterBody2D>(body.GetPath());
		QueueFree();
	}
}
