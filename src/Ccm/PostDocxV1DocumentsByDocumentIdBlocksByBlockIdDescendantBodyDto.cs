// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostDocxV1DocumentsByDocumentIdBlocksByBlockIdDescendantBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建嵌套块 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建嵌套块 请求体
/// <para>接口ID：7324523155900366876</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/docs/document-block/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-descendant%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsByDocumentIdBlocksByBlockIdDescendantBodyDto
{
    /// <summary>
    /// <para>添加的孩子 BlockID 列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("children_id")]
    public string[] ChildrenId { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>当前 Block 在 Children 中的插入位置，起始值为 0，最大值为原 Children 长度</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>最小值：-1</para>
    /// <para>默认值：-1</para>
    /// </summary>
    [JsonPropertyName("index")]
    public int? Index { get; set; }

    /// <summary>
    /// <para>添加的子孙列表，包括孩子</para>
    /// <para>必填：是</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("descendants")]
    public Dtos.Block[] Descendants { get; set; } = Array.Empty<Dtos.Block>();
}
