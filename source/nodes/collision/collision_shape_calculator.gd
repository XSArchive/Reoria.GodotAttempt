@tool class_name CollisionShapeCalculator extends CollisionShape2D

@export var sprite_node_path: NodePath
@export var position_snap: Vector2 = Vector2.ZERO
@export var position_offset: Vector2 = Vector2.ZERO
@export var size_multipliers: Vector2 = Vector2(1, 1)

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	if(Engine.is_editor_hint()):
		_on_sprite_draw()
	pass

func _on_sprite_draw():
	var sprite: Sprite2D = get_node_or_null(sprite_node_path)
	if(sprite != null):
		var rect: Vector2 = (sprite.get_rect().size)
		
		position = rect * (position_snap / 2) + position_offset
		
		if(shape is CircleShape2D):
			shape.set("radius", (rect * size_multipliers).y)
		elif(shape is CapsuleShape2D):
			shape.set("radius", (rect * size_multipliers).x)
			shape.set("height", (rect * size_multipliers).y)
		elif(shape is RectangleShape2D):
			shape.set("size", (rect * size_multipliers))
