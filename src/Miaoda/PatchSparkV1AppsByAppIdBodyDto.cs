// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="PatchSparkV1AppsByAppIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新妙搭应用信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 更新妙搭应用信息 请求体
/// <para>更新妙搭应用信息</para>
/// <para>接口ID：7642228089434934453</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fpatch</para>
/// </summary>
public record PatchSparkV1AppsByAppIdBodyDto
{
    /// <summary>
    /// <para>应用名称，用于在管理后台和前端展示，支持中英文，长度不超过64字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：智能客服助手</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>应用功能说明，用于向用户介绍应用核心能力，长度不超过200字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：提供7×24小时智能对话服务，支持常见问题自动解答与工单流转</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>应用图标访问地址，支持PNG/JPG格式，建议尺寸为128×128像素</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://example.com/app-icons/customer-service.png</para>
    /// </summary>
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; set; }
}
