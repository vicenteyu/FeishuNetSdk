// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>升级表单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 升级表单 请求体
/// <para>升级旧版表单至收集表</para>
/// <para>接口ID：7600708368865873109</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form/upgrade</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fupgrade</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeBodyDto
{
    /// <summary>
    /// <para>升级后的表单名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：文档问题反馈</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("form_name")]
    public string FormName { get; set; } = string.Empty;

    /// <summary>
    /// <para>表单布局模式。</para>
    /// <para>必填：是</para>
    /// <para>示例值：one_question_per_page</para>
    /// <para>可选值：<list type="bullet">
    /// <item>traditional：传统布局</item>
    /// <item>one_question_per_page：一页一题布局</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("display_mode")]
    public string DisplayMode { get; set; } = string.Empty;
}
