// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApplicationBotMenuV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>机器人自定义菜单事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 机器人自定义菜单事件 事件体
/// <para>当用户点击类型为事件的机器人菜单时触发{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=bot&amp;event=menu)</para>
/// <para>接口ID：7176243808379977730</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/bot-v3/events/menu</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fbot%2fevents%2fmenu</para>
/// </summary>
public record ApplicationBotMenuV6EventBodyDto() : EventBodyDto("application.bot.menu_v6")
{
    /// <summary>
    /// <para>用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public OperatorSuffix? Operator { get; set; }

    /// <summary></summary>
    public record OperatorSuffix
    {
        /// <summary>
        /// <para>用户名称</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `100` 字符</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- application:application.bot.operator_name:readonly : 获取机器人自定义菜单操作人名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string? OperatorName { get; set; }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public UserIdSuffix? OperatorId { get; set; }
    }

    /// <summary>
    /// <para>菜单事件的唯一标识</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `30` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_key")]
    public string? EventKey { get; set; }

    /// <summary>
    /// <para>用户点击菜单时间</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `30`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long? Timestamp { get; set; }
}
