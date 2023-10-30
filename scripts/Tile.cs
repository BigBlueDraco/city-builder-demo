using Godot;
using System;

public partial class Tile : Node3D
{
	private Node3D node;
	private int RotationPosition
  	{
		get { return RotationPosition; }   
		set
		{ 
			this.RotationPosition = 4*value%4;
		}  
  	}
    private int rotationPosition; 

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
	// public void RotateLeft()
	// {
    //     RotationPosition = RotationPosition - 1;
    //     float rad = (float)((RotationPosition * 90 / (180 / Math.PI)));
    //     this.node.RotateY(rad);
	// }
	// public void RotateRight()
	// {
    //     RotationPosition = RotationPosition + 1;
    //     float rad = (float)((RotationPosition * 90 / (180 / Math.PI)));
    //     this.node.RotateY(rad);
	// }
	public override void _Ready()
	{
		this.Render();
	}
}
