using Godot;
using System;

public partial class OutOfBoundsArea : Area2D
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

    public void _OnOutOfBoundsAreaBodyEntered(Node2D body)
    {
        Ball ball = GetNode<Ball>(body.GetPath());
        ball.ResetPosition();
    }
}
