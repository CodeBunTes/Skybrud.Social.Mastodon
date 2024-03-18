using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Mastodon.Models.CustomEmojis;

/// <summary>
/// Class representing a Custom Emoji
/// </summary>
/// <see>
///     <cref>https://docs.joinmastodon.org/entities/CustomEmoji/</cref>
/// </see>
public class MastodonCustomEmoji : MastodonObject {

    #region Properties

    /// <summary>
    /// Gets the name of the custom emoji.
    /// </summary>
    /// <see>
    ///     <cref>https://docs.joinmastodon.org/entities/CustomEmoji/#shortcode</cref>
    /// </see>
    public string Shortcode { get; }

    /// <summary>
    /// Gets a link to the custom emoji.
    /// </summary>
    /// <see>
    ///     <cref>https://docs.joinmastodon.org/entities/CustomEmoji/#url</cref>
    /// </see>
    public string Url { get; }

    /// <summary>
    /// Gets a link to a static copy of the custom emoji.
    /// </summary>
    /// <see>
    ///     <cref>https://docs.joinmastodon.org/entities/CustomEmoji/#static_url</cref>
    /// </see>
    public string StaticUrl { get; }

    /// <summary>
    /// Gets whether this Emoji should be visible in the picker or unlisted
    /// </summary>
    /// <see>
    ///     <cref>https://docs.joinmastodon.org/entities/CustomEmoji/#visible_in_picker</cref>
    /// </see>
    public bool VisibleInPicker { get; }

    /// <summary>
    /// Gets a category used for sorting custom emoji in the picker. Added in 3.0.0
    /// </summary>
    /// <see>
    ///     <cref>https://docs.joinmastodon.org/entities/CustomEmoji/#category</cref>
    /// </see>
    public string? Category { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="json"/>.
    /// </summary>
    /// <param name="json">The JSON object representing the instance.</param>
    protected MastodonCustomEmoji(JObject json) : base(json) {
        Shortcode = json.GetString("shortcode")!;
        Url = json.GetString("url")!;
        StaticUrl = json.GetString("static_url")!;
        VisibleInPicker = json.GetBoolean("visible_in_picker");
        Category = json.GetString("category");
    }

    #endregion

    #region Static methods

    /// <summary>
    /// Initializes a new instance based on the specified <paramref name="json"/> object.
    /// </summary>
    /// <param name="json">The JSON object representing the Custom Emoji.</param>
    /// <returns>An instance of <see cref="MastodonCustomEmoji"/>.</returns>
    public static MastodonCustomEmoji Parse(JObject json) {
        return new MastodonCustomEmoji(json);
    }

    #endregion

}
