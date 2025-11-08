// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-08
//
// Last Modified By : yxr
// Last Modified On : 2025-11-08
// ************************************************************************
// <copyright file="PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>解析画板语法 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 解析画板语法 响应体
/// <para>用户可以将PlantUml/Mermaid图表导入画板进行协同编辑</para>
/// <para>接口ID：7567790459344879618</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create_plantuml</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate_plantuml</para>
/// </summary>
public record PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlResponseDto
{
    /// <summary>
    /// <para>创建生成的plant uml节点id</para>
    /// <para>必填：否</para>
    /// <para>示例值：t1:1</para>
    /// </summary>
    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }
}
