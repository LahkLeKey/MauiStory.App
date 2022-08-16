namespace Entity.Shared;

/// <summary>
///     Game Entity Base Class
/// </summary>
public partial class GameEntity
{
    /// <summary>
    ///     Initialize default context.
    /// </summary>
    public GameEntity()
    {
        RenderTargetType = Type.Sprite;
    }

    
    /// <summary>
    ///     Types of valid game entities.
    /// </summary>
    public enum Type
    {
        /// <summary>
        ///     Generic Text Message
        /// </summary>
        Text,

        
        /// <summary>
        ///     Generic Sprite
        /// </summary>
        Sprite
    }

    /// <summary>
    ///     Absolute world position. Screen position will be dynamically calculated based on this value.
    /// </summary>
    public object WorldPosition = new { x = 0, y = 0 };

   
    /// <summary>
    ///     Globally Unique ID for this instance.
    /// </summary>
    public Guid Guid { get; } = Guid.NewGuid();

   
    /// <summary>
    ///     Text or Base64 data that will be rendered to the screen.
    /// </summary>
    public string? RenderTarget { get; set; }

   
    /// <summary>
    ///     Render target type for this instance.
    /// </summary>
    public Type? RenderTargetType { get; set; }
}