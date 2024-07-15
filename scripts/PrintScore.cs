using Godot;
using System;

public partial class PrintScore : RichTextLabel{
	private RichTextLabel rtl;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta){
		String text = this.Text;
        GD.Print(text);
	}
}

