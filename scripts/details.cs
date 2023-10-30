using Godot;
using System;
using System.Collections.Generic;
using static System.Random;

public partial class details : Node3D
{
	[Export]
	private int detailsCount  = 1;

	[Export]
	private Node[] obj = new Node[1];
	public override void _Ready()
	{

		var rand = new Random();
		
		obj[rand.Next(0, obj.Length)].QueueFree();

	}

	public override void _Process(double delta)
	{
	}
}
