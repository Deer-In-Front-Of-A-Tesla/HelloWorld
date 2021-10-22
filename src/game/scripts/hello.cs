using Godot;
using System;

public class hello : Button
{
	[Export]
	public NodePath _label;

	public override void _Pressed() {
		GetNode<Label>(_label).Text = "HELLO FROM CS";
	}
}
