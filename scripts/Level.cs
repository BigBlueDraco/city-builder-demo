using System;
using Godot;

public partial class Level : Node3D
{
	private Random rand = new Random();
	[Export]
	private int width = 5;
	[Export]
	private int height = 5;
	[Export]
	private PackedScene[] tiles = new PackedScene[1];

	protected void Render()
	{
		Node3D[,] level = new Node3D[width, height];
		
		for(int w = 0; w<= width-1; w++){
		for(int h = 0; h<= height-1; h++){
			Tile node  = (Tile)tiles[rand.Next(0, tiles.Length)].Instantiate();
			node.Position = new Vector3(1+w*2,0,1+h*2);
			AddChild(node);
			level[w,h] = node;
		}}
	}
	public override void _Ready()
	{
		this.Render();
	}
}




