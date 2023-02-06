using Godot;
using System;

public partial class Paddle : CharacterBody2D
{
	public const float Speed = 300.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.x = direction.x * Speed * (float)delta;
		} else {
			velocity.x = 0.0f;
		}

		Velocity = velocity;
		var collision = MoveAndCollide(velocity);
	}
}
