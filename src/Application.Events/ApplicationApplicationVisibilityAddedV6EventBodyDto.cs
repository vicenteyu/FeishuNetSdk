// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="ApplicationApplicationVisibilityAddedV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工免审安装应用 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 员工免审安装应用 事件体
/// <para>以下场景会触发该事件，事件体内包含对应用户的 ID 信息。</para>
/// <para>- 员工免审安装商店应用。功能介绍参见[员工免审安装应用](https://open.feishu.cn/document/uAjLw4CM/uYjL24iN/platform-overveiw/develop-process/configuring-employee-review-free-installation)。</para>
/// <para>- 员工免审加入商店应用可用范围。当员工免审安装商店应用后，企业内其他员工在该应用详情页内获取应用时，员工会加入应用可用范围内，并触发该事件。</para>
/// <para>使用限制：</para>
/// <para>应用必须是商店应用，且应用需要订阅该事件。了解事件订阅的使用场景和配置流程，请点击查看 [事件订阅概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。</para>
/// <para>接口ID：7013340088257511452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/app-availability-scope-extended</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fevent%2fapp-availability-scope-extended</para>
/// </summary>
public record ApplicationApplicationVisibilityAddedV6EventBodyDto() : EventBodyDto("application.application.visibility.added_v6")
{
    /// <summary>
    /// <para>该字段暂无实际含义，可忽略</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("source")]
    public int? Source { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public User[]? Users { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record User
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public UserIdSuffix? UserId { get; set; }
    }
}
