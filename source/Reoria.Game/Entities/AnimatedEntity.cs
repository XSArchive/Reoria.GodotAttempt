using Godot;
using Reoria.Game.Entities.Interfaces;

namespace Reoria.Game.Entities
{
    public partial class AnimatedEntity : StaticEntity, IAnimatedEntity
    {
        [Export]
        public AnimatedSprite2D animatedSprite { get; protected set; }

        public override void _Ready()
        {
            base._Ready();

            animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite") ?? throw new NullReferenceException("Unable to instantiate StaticEntity node: Could not find component AnimatedSprite2D.");
        }
    }
}
