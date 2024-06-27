// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ImgCombinationElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多图混排组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 多图混排组件
    /// </summary>
    /// <param name="CombinationMode">
    /// 多图混排的方式，可取值：
    /// <para>注意：若上传的图片数量超过混排方式可容纳的上限，则系统将根据图片上传的顺序，优先展示排列顺序中靠前的图片。超出上限的图片将不再显示。</para>
    /// <para>若上传的图片数量未达到混排方式可容纳的上限，则未排布的部分将保留空白。</para>
    /// <list type="bullet">
    /// <item>double：双图混排，最多可排布两张图。</item>
    /// <item>triple：三图混排，最多可排布三张图。</item>
    /// <item>bisect：等分双列图混排，每行两个等大的正方形图，最多可排布三行，即六张图。</item>
    /// <item>trisect：等分三列图混排，每行三个等大的正方形图，最多可排布三行，即九张图。</item>
    /// </list>
    /// </param>
    /// <param name="CornerRadius">
    /// 多图混排图片的圆角半径，单位是像素（px）。取值遵循以下格式：
    /// <list type="bullet">
    /// <item>[0,∞]px</item>
    /// <item>[0,100]%</item>
    /// </list>
    /// </param>
    /// <param name="ImgList">图片资源的 img_key 数组，顺序与图片排列顺序一致。</param>
    public record ImgCombinationElement([property: JsonPropertyName("combination_mode")] string CombinationMode = "",
        [property: JsonPropertyName("corner_radius")] string? CornerRadius = null,
        [property: JsonPropertyName("img_list")] ImgCombinationElement.Img[] ImgList = default!) : Element("img_combination")
    {
        /// <summary>
        /// 图片资源
        /// </summary>
        /// <param name="ImgKey">图片资源的 Key。你可以调用上传图片接口或在搭建工具中上传图片，获取图片的 key。</param>
        public record Img([property: JsonPropertyName("img_key")] string ImgKey = "");
    }
}
