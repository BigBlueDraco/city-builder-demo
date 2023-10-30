using System;
using Godot;

partial class Cell:Node3D
{
	public Boolean isCollapsed; 
	public PackedScene[] variants;
	public Cell(PackedScene[] variants)
	{
		this.variants= variants;
		this.isCollapsed = false;
	}
}
[Tool]
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
		Cell[,] grid = new Cell[width, height];
		for(int w = 0; w<= width-1; w++){
		for(int h = 0; h<= height-1; h++)
		{
			grid[w,h] = new Cell(tiles);
		}}
		for(int w = 0; w<= width-1; w++){
		for(int h = 0; h<= height-1; h++)
		{

			var elem = grid[w,h];
			PackedScene[] variant = new PackedScene[1];
			Tile node = (Tile)elem.variants[0].Instantiate();
			// GD.Print(elem.variants[0].right);
			var child = node.GetChildren();
			GD.Print(child);
			// elem.variants[rand.Next(0, elem.variants.Length)].Instantiate();
			elem.isCollapsed = true;
			// Tile node = elem.variants[rand.Next(0, elem.variants.Length)];
			// node.Position = new Vector3(1+w*2,0,1+h*2);
			// AddChild(elem.variants[rand.Next(0, elem.variants.Length)]);
			// grid[w+1, h].variants = node.right;
			// grid[w-1, h].variants = node.left;
			// grid[w, h-1].variants = node.down;
			// grid[w, h+1].variants = node.up;
		}}
	}
	public override void _Ready()
	{
		this.Render();
	}
}




