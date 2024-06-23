// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenVersionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建文档版本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文档版本 请求体
/// <para>创建文档版本。</para>
/// <para>接口ID：7156062028485033988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-version/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-version%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenVersionsBodyDto
{
    /// <summary>
    /// <para>版本文档标题，该参数必填，请忽略左侧必填列显示的“否”。</para>
    /// <para>最大长度 1024 个Unicode 码点。通常情况下，一个英文或中文字符对应一个码点，但是某些特殊符号可能会对应多个码点。例如，家庭组合「👨‍👩‍👧」这个表情符号对应5个码点。</para>
    /// <para>必填：否</para>
    /// <para>示例值：文档标题</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>版本文档类型，该参数必填，请忽略左侧必填列显示的“否”</para>
    /// <para>必填：否</para>
    /// <para>示例值：docx</para>
    /// <para>可选值：<list type="bullet">
    /// <item>docx：新版文档</item>
    /// <item>sheet：电子表格</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("obj_type")]
    public string? ObjType { get; set; }
}
