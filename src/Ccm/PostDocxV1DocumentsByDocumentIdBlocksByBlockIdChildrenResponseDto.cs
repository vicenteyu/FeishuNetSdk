// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建块 响应体
/// <para>指定需要操作的块，为其创建一批子块，并插入到指定位置。如果操作成功，接口将返回新创建子块的富文本内容。</para>
/// <para>接口ID：7068199542315270172</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto
{
    /// <summary>
    /// <para>所添加的孩子的 Block 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("children")]
    public Dtos.Block[]? Childrens { get; set; }

    /// <summary>
    /// <para>当前 block children 创建成功后文档的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("document_revision_id")]
    public int? DocumentRevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string ClientToken { get; set; } = string.Empty;
}
