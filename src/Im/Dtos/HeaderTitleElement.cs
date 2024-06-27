// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="HeaderTitleElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>标题元素。必须配置 content 或 i18n 两个属性的其中一个。如果同时配置仅生效 i18n。</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 标题元素。必须配置 content 或 i18n 两个属性的其中一个。如果同时配置仅生效 i18n。
    /// </summary>
    /// <param name="Content">标题内容</param>
    /// <param name="I18n">多语言标题内容
    /// <list type="bullet">
    /// <item>zh_cn：简体中文</item>
    /// <item>en_us：英文</item>
    /// <item>ja_jp：日文</item>
    /// <item>zh_hk：繁体中文（中国香港）</item>
    /// <item>zh_tw：繁体中文（中国台湾）</item>
    /// </list>
    /// </param>
    public record HeaderTitleElement([property: JsonPropertyName("content")] string Content = "",
        [property: JsonPropertyName("i18n")] I18nLanguage<string>? I18n = null) : Element("plain_text");
}
