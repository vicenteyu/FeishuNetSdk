// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ImgElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图片消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 图片消息
    /// </summary>
    /// <param name="ImgKey">图片的唯一标识，可通过 上传图片 接口获取image_key。</param>
    /// <param name="Mode">
    /// 图片显示模式。取值：
    /// <para>注意：设置该参数后，会覆盖 custom_width 参数。更多信息参见消息卡片设计规范。</para>
    /// <list type="bullet">
    /// <item>crop_center：居中裁剪模式，对长图会限高，并居中裁剪后展示。</item>
    /// <item>fit_horizontal：平铺模式，宽度撑满卡片完整展示上传的图片。</item>
    /// <item>stretch：自适应。图片宽度撑满卡片宽度，当图片 高:宽 小于 16:9 时，完整展示原图。当图片 高:宽 大于 16:9 时，顶部对齐裁剪图片，并在图片底部展示 长图 脚标。</item>
    /// <item>large：大图，尺寸为 160 × 160，适用于多图混排。</item>
    /// <item>medium：中图，尺寸为 80 × 80，适用于图文混排的封面图。</item>
    /// <item>small：小图，尺寸为 40 × 40，适用于人员头像。</item>
    /// <item>tiny：超小图，尺寸为 16 × 16，适用于图标、备注。</item>
    /// </list>
    /// </param>
    /// <param name="Alt">悬浮（hover）在图片上时展示的说明文案。</param>
    /// <param name="Title">图片标题。</param>
    /// <param name="CornerRadius">
    /// 图片的圆角半径，单位是像素（px）。取值遵循以下格式：
    /// <list type="bullet">
    /// <item>[0,∞]px</item>
    /// <item>[0,100]%</item>
    /// </list>
    /// </param>
    /// <param name="ScaleType">
    /// 图片的裁剪模式，当 size 字段的比例和图片的比例不一致时会触发裁剪。可取值：
    /// <list type="bullet">
    /// <item>crop_center：居中裁剪</item>
    /// <item>crop_top：顶部裁剪</item>
    /// <item>fit_horizontal：完整展示不裁剪</item>
    /// </list>
    /// </param>
    /// <param name="Size">
    /// 图片尺寸。仅在 scale_type 字段为 crop_center 或 crop_top 时生效。可取值：
    /// <list type="bullet">
    /// <item>large：大图，尺寸为 160 × 160，适用于多图混排。</item>
    /// <item>medium：中图，尺寸为 80 × 80，适用于图文混排的封面图。</item>
    /// <item>small：小图，尺寸为 40 × 40，适用于人员头像。</item>
    /// <item>tiny：超小图，尺寸为 16 × 16，适用于图标、备注。</item>
    /// <item>stretch_without_padding：通栏图，适用于高宽比小于 16:9 的图片，图片的宽度将撑满卡片宽度。</item>
    /// <item>stretch：超大图，适用于高宽比小于 16:9 的图片。</item>
    /// <item>[1,999]px [1,999]px：自定义图片尺寸，单位为像素，中间用空格分隔。</item>
    /// </list>
    /// </param>
    /// <param name="CustomWidth">自定义图片的最大展示宽度，支持在 278px ~ 580px 范围内指定最大展示宽度。默认情况下图片宽度与图片组件所占区域的宽度一致。</param>
    /// <param name="Transparent">是否为透明底色。默认为 false，即图片为白色底色。</param>
    /// <param name="Preview">
    /// 点击后是否放大图片。
    /// <para>提示：如果你为卡片配置了跳转链接card_link参数，可将该参数设置为 false，后续用户点击卡片上的图片也能响应 card_link 链接跳转。</para>
    /// <list type="bullet">
    /// <item>true：点击图片后，弹出图片查看器放大查看当前点击的图片。</item>
    /// <item>false：点击图片后，响应卡片本身的交互事件，不弹出图片查看器。</item>
    /// </list>
    /// </param>
    /// <param name="CompactWidth">是否展示为紧凑型的图片。如果配置为 true，则展示最大宽度为 278px 的紧凑型图片。</param>
    public record ImgElement([property: JsonPropertyName("img_key")] string ImgKey = "",
        [property: JsonPropertyName("mode")] string? Mode = null,
        [property: JsonPropertyName("alt")] PlainTextElement? Alt = null,
        [property: JsonPropertyName("title")] PlainTextElement? Title = null,
        [property: JsonPropertyName("corner_radius")] string? CornerRadius = null,
        [property: JsonPropertyName("scale_type")] string? ScaleType = null,
        [property: JsonPropertyName("size")] string? Size = null,
        [property: JsonPropertyName("custom_width")] string? CustomWidth = null,
        [property: JsonPropertyName("transparent")] bool? Transparent = null,
        [property: JsonPropertyName("preview")] bool? Preview = null,
        [property: JsonPropertyName("compact_width")] bool? CompactWidth = null) : Element("img"), IAmNoteElement;

    /// <summary>
    /// 图片消息（ PostContent 使用）
    /// </summary>
    /// <param name="ImageKey">图片的唯一标识，可通过 上传图片 接口获取image_key。</param>
    public record ImageElement([property: JsonPropertyName("image_key")] string ImageKey = "") : Element("img"), IAmNoteElement;
}
