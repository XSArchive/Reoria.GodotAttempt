using Godot;
using Reoria.Game.Entities.Interfaces;

namespace Reoria.Game.Entities
{
    public partial class StaticEntity : Entity, IStaticEntity
    {
        [Export]
        public Sprite2D sprite { get; protected set; }
        [Export]
        public Node2D collisionCalculator { get; protected set; }

        public override void _Ready()
        {
            base._Ready();

            sprite = GetNode<Sprite2D>("Sprite") ?? throw new NullReferenceException("Unable to instantiate StaticEntity node: Could not find component Sprite2D.");
            collisionCalculator = GetNode<Node2D>("SpriteCollisionCalculator") ?? throw new NullReferenceException("Unable to instantiate StaticEntity node: Could not find component Node2D.");
        }
    }
}
