// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBotV3InfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取机器人信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 获取机器人信息 响应体
/// <para>获取机器人的基本信息。</para>
/// <para>接口ID：6907569745299111938</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/bot-v3/obtain-bot-info</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjMxEjLwITMx4CMyETM</para>
/// </summary>
public record GetBotV3InfoResponseDto
    : FeishuResponse<GetBotV3InfoResponseDto.BotInfo>
{
    /// <summary>
    /// 业务数据
    /// </summary>
    [JsonIgnore]
    public override BotInfo? Data => Bot;

    /// <summary>
    /// <para>机器人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bot")]
    public BotInfo? Bot { get; set; }

    /// <summary>
    /// <para>机器人信息</para>
    /// </summary>
    public record BotInfo
    {
        /// <summary>
        /// <para>app 当前状态。</para>
        /// <para>0: 初始化，租户待安装</para>
        /// <para>1: 租户停用</para>
        /// <para>2: 租户启用</para>
        /// <para>3: 安装后待启用</para>
        /// <para>4: 升级待启用</para>
        /// <para>5: license过期停用</para>
        /// <para>6: Lark套餐到期或降级停用</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("activate_status")]
        public int? ActivateStatus { get; set; }

        /// <summary>
        /// <para>app 名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// <para>app 图像地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>app 的 IP 白名单地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ip_white_list")]
        public string[]? IpWhiteList { get; set; }

        /// <summary>
        /// <para>机器人的open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }
    }
}
