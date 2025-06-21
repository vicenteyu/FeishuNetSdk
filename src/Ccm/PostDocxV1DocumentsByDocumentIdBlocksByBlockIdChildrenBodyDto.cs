// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建块 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建块 请求体
/// <para>指定需要操作的块，为其创建一批子块，并插入到指定位置。如果操作成功，接口将返回新创建子块的富文本内容。</para>
/// <para>接口ID：7068199542315270172</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBodyDto
{
    /// <summary>
    /// <para>添加的孩子列表。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("children")]
    public Dtos.Block[]? Childrens { get; set; }

    /// <summary>
    /// <para>当前 block 在 children 中的插入位置，起始值为 0，最大值为原 children 长度</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>默认值：-1</para>
    /// </summary>
    [JsonPropertyName("index")]
    public int? Index { get; set; }
}
