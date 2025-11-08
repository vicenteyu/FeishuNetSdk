// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-08
//
// Last Modified By : yxr
// Last Modified On : 2025-11-08
// ************************************************************************
// <copyright file="PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>解析画板语法 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 解析画板语法 请求体
/// <para>用户可以将PlantUml/Mermaid图表导入画板进行协同编辑</para>
/// <para>接口ID：7567790459344879618</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create_plantuml</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate_plantuml</para>
/// </summary>
public record PostBoardV1WhiteboardsByWhiteboardIdNodesPlantumlBodyDto
{
    /// <summary>
    /// <para>plant uml 代码</para>
    /// <para>必填：是</para>
    /// <para>示例值：@startuml\nAlice -&gt; Bob: Authentication Request\nBob --&gt; Alice: Authentication Response\n@enduml</para>
    /// <para>最大长度：1000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("plant_uml_code")]
    public string PlantUmlCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>画板样式（默认为2 经典样式）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：画板样式（解析之后为多个画板节点，粘贴到画板中，不可对语法进行二次编辑）</item>
    /// <item>2：经典样式（解析之后为一张图片，粘贴到画板中，可对语法进行二次编辑）（只有PlantUml语法支持经典样式）</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("style_type")]
    public int? StyleType { get; set; }

    /// <summary>
    /// <para>语法类型（必传）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知</item>
    /// <item>1：Plantuml解析</item>
    /// <item>2：Mermaid解析</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("syntax_type")]
    public int? SyntaxType { get; set; }

    /// <summary>
    /// <para>PlantUml语法类型（传0会自动识别语法类型，plantUML语法补充超集GML不可自动识别）</para>
    /// <para>当syntax_type为2（Mermaid解析）时，diagram_type传 0， 默认为 0</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：未知</item>
    /// <item>1：思维导图</item>
    /// <item>2：时序图</item>
    /// <item>3：活动图</item>
    /// <item>4：类图</item>
    /// <item>5：ER</item>
    /// <item>6：流程图</item>
    /// <item>7：用例图</item>
    /// <item>8：组件图</item>
    /// <item>101：ai流式生成流程图</item>
    /// <item>102：ai流式生成时序图</item>
    /// <item>201：plantUML语法补充超集GML</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("diagram_type")]
    public int? DiagramType { get; set; }
}
