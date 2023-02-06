using Godot;
using System;

public partial class SceneManager : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public void GoToScene(string sceneName)
	{
		CallDeferred(nameof(DeferredGoToScene), sceneName);
	}

	public void DeferredGoToScene(string sceneName)
	{
		var scene = GD.Load<PackedScene>(sceneName);
		GetTree().ChangeSceneToPacked(scene);
	}
}
