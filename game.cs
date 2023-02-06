using Godot;
using System;

public partial class game : Node2D
{
    SceneManager sceneManager;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        sceneManager = GetNode<SceneManager>("/root/SceneManager");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        var nodes = GetTree().GetNodesInGroup("bricks");
        if (nodes.Count == 0)
        {
            sceneManager.GoToScene("res://start_screen.tscn");
        }
    }
}
