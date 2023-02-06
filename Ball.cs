using Godot;
using System;

public partial class Ball : CharacterBody2D
{
	Vector2 startPosition;
	Vector2 startVelocity;
	RichTextLabel scoreLabel;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.startPosition = this.Position;
		this.startVelocity = this.Velocity = new Vector2(200, -200);
		this.scoreLabel = GetNode<RichTextLabel>("../Score");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Space))
		{
			this.Position = this.startPosition;
			this.Velocity = this.startVelocity;
		}
	}

    public override void _PhysicsProcess(double delta)
    {
		KinematicCollision2D collision = MoveAndCollide(this.Velocity * (float)delta);
		if (collision != null)
		{
			Node2D body = collision.GetCollider() as Node2D;

			if (body is not null && body.IsInGroup("bricks"))
			{
				this.UpdateScore();
				body.QueueFree();
			}

			this.Velocity = this.Velocity.Bounce(collision.GetNormal());
		}
    }

	public void ResetPosition()
	{
		this.Position = this.startPosition;
		this.Velocity = Vector2.Zero;
	}

	public void UpdateScore()
	{
		this.scoreLabel.Text = (int.Parse(this.scoreLabel.Text) + 1).ToString();
	}
}
