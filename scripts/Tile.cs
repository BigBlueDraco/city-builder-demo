using Godot;
using System;
using System.Dynamic;

[Tool]
public partial class Tile : Node3D
{
	private Node3D node;
	private int rotationPosition; 
	[Export]
	private PackedScene[] up = new PackedScene[0];
	[Export]
	private PackedScene[] left = new PackedScene[0];
	[Export]
	private PackedScene[] right = new PackedScene[0];
	[Export]
	private PackedScene[] down = new PackedScene[0];
	
	public PackedScene[] GetUp()
	{
		return up;
	}
	public Tile()
	{
		this.rotationPosition = 0;
	}

	private Random rand = new Random();
	[Export]
	private PackedScene[] variants = new PackedScene[1];
	protected void Render(){
		GD.Print(this);
		Node3D node  = (Node3D)variants[rand.Next(0, variants.Length)].Instantiate();
		AddChild(node);
		this.node = node;
	}
	public void RotateLeft(int times = 1)
	{
		this.rotationPosition =((this.rotationPosition+times)%4);
		GD.Print((this.rotationPosition+times)%4);
		float rad = (float)((this.rotationPosition  * 90) / (180 / Math.PI));
		this.node.RotateY(rad);
	}
	public void RotateRight(int times = 1)
	{
		this.rotationPosition =((this.rotationPosition+times)%4);
		GD.Print((this.rotationPosition+times)%4);
		float rad = (float)((this.rotationPosition  * 90) / (180 / Math.PI));
		this.node.RotateY(rad);
	}
	public override void _Ready()
	{
		this.Render();
	}
}
