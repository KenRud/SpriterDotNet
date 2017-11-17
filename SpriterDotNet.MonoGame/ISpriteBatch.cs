using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpriterDotNet.MonoGame
{
    /// <summary>
    /// Interface that encapsulates a basic sprite batcher. This layer of abstraction is needed 
    /// because MonoGame framework extensions like "MonoGame Extended" and "Nez" create their own
    /// sprite batch implementations. This interface removes the dependency on the default 
    /// SpriteBatcher included with MonoGame.
    /// </summary>
    public interface ISpriteBatch
    {
        void Draw(
            Texture2D texture,
            Vector2 position,
            Color color,
            float rotation,
            Vector2 origin,
            Vector2 scale,
            SpriteEffects effects,
            float layerDepth);

        void Draw(
            Texture2D texture,
            Vector2 position,
            Color color,
            float rotation,
            Vector2 origin,
            Vector2 scale,
            SpriteEffects effects,
            float layerDepth,
            Rectangle sourceRectangle);
    }
}