// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="CodeBlockElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>代码块</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 代码块
    /// </summary>
    /// <param name="Text">代码块内容</param>
    /// <param name="Language">
    /// 代码块语言，不填为文本类型，可选值有：，不区分大小写
    /// <list type="bullet">
    /// <item>PYTHON</item>
    /// <item>C</item>
    /// <item>CPP</item>
    /// <item>GO</item>
    /// <item>JAVA</item>
    /// <item>KOTLIN</item>
    /// <item>SWIFT</item>
    /// <item>PHP</item>
    /// <item>RUBY</item>
    /// <item>RUST</item>
    /// <item>JAVASCRIPT</item>
    /// <item>TYPESCRIPT</item>
    /// <item>BASH</item>
    /// <item>SHELL</item>
    /// <item>SQL</item>
    /// <item>JSON</item>
    /// <item>XML</item>
    /// <item>YAML</item>
    /// <item>HTML</item>
    /// <item>THRIFT</item>
    /// </list>
    /// </param>
    public record CodeBlockElement([property: JsonPropertyName("text")] string Text = "",
        [property: JsonPropertyName("language")] string? Language = null) : Element("code_block");
}
