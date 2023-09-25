using Godot;
using Reoria.Game.Entities.Interfaces;

namespace Reoria.Game.Entities
{
    public partial class Entity : CharacterBody2D, IEntity
    {
        [Export]
        public CollisionShape2D collision { get; protected set; }

        public override void _Ready()
        {
            base._Ready();

            collision = GetNode<CollisionShape2D>("Collision") ?? throw new NullReferenceException("Unable to instantiate Entity node: Could not find componentCollisionShape2D.");
        }
    }
}
