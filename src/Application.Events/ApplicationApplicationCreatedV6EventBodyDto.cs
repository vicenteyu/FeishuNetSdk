// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApplicationApplicationCreatedV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>应用创建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 应用创建 事件体
/// <para>当企业内有新的应用被创建时推送此事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=application&amp;event=created)</para>
/// <para>接口ID：7050360820601405468</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fevents%2fcreated</para>
/// </summary>
public record ApplicationApplicationCreatedV6EventBodyDto() : EventBodyDto("application.application.created_v6")
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>应用 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>应用名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>应用描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>应用图标链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }

    /// <summary>
    /// <para>应用类型，0: 自建应用，1: 应用商店应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app_scene_type")]
    public int? AppSceneType { get; set; }

    /// <summary>
    /// <para>应用主语言</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("primary_language")]
    public string? PrimaryLanguage { get; set; }

    /// <summary>
    /// <para>应用创建来源</para>
    /// <para>**可选值有**：</para>
    /// <para>developer_console:开发者后台,base:多维表格自动化流程创建的应用,app_engine:飞书应用引擎,bot_builder:机器人助手,aily:aily(智能伙伴搭建平台),unknown:未知来源</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>developer_console：开发者后台</item>
    /// <item>base：多维表格自动化流程创建的应用</item>
    /// <item>app_engine：飞书应用引擎</item>
    /// <item>bot_builder：机器人助手</item>
    /// <item>aily：aily(智能伙伴搭建平台)</item>
    /// <item>unknown：未知来源</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("create_source")]
    public string? CreateSource { get; set; }
}
