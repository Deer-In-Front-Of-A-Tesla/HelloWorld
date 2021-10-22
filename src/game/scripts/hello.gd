extends Button

export(NodePath) onready var _label = get_node(_label) as Label;
	
func _pressed():
	_label.text = "HELLO FROM GD"
