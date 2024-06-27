// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PostContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>富文本消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 富文本消息
    /// </summary>
    /// <param name="Post">富文本消息。post content格式请参见发送消息Content</param>
    public record PostContent([property: JsonPropertyName("post")] I18nLanguage<PostContent.PostLanguage> Post = default!)
        : MessageContent("post")
    {
        /// <summary>
        /// 富文本消息
        /// <para>扩展方法：
        /// <list type="bullet">
        /// AddContent：添加富文本元素节点
        /// </list>
        /// </para>
        /// </summary>
        public record PostLanguage
        {
            /// <summary>
            /// 标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; } = string.Empty;

            /// <summary>
            /// 富文本消息内容
            /// <para>富文本可以在一条消息中同时支持文字、At、图片、视频、超链接等元素。</para>
            /// <para>一个富文本可分多个段落（由多个[]组成），每个段落可由多个元素组成，每个元素由tag和相应的字段描述组成。主要图片元素必须是独立的一个段落。</para>
            /// 支持的元素清单如下：位于 Im.Dtos 空间下
            /// <list type="bullet">
            /// <item>TextElement</item>
            /// <item>LinkElement</item>
            /// <item>AtElement</item>
            /// <item>ImgElement</item>
            /// <item>MediaElement</item>
            /// <item>EmotionElement</item>
            /// <item>HrElement</item>
            /// <item>MdElement</item>
            /// <item>CodeBlockElement</item>
            /// </list>
            /// </summary>
            [JsonPropertyName("content")]
            public object[][] Content { get; set; } = Array.Empty<object[]>();
        }
    }
}
