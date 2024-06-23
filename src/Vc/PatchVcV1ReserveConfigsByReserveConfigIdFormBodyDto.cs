// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchVcV1ReserveConfigsByReserveConfigIdFormBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新会议室预定表单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 更新会议室预定表单 请求体
/// <para>更新会议室预定表单。</para>
/// <para>接口ID：7194790671877160962</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config-form%2fpatch</para>
/// </summary>
public record PatchVcV1ReserveConfigsByReserveConfigIdFormBodyDto
{
    /// <summary>
    /// <para>1代表层级，2代表会议室</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("scope_type")]
    public int ScopeType { get; set; }

    /// <summary>
    /// <para>预定表单设置</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("reserve_form_config")]
    public PatchVcV1ReserveConfigsByReserveConfigIdFormBodyDtoReserveFormConfig ReserveFormConfig { get; set; } = new();

    /// <summary>
    /// <para>预定表单设置</para>
    /// </summary>
    public record PatchVcV1ReserveConfigsByReserveConfigIdFormBodyDtoReserveFormConfig
    {
        /// <summary>
        /// <para>是否覆盖子层级及会议室</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("if_cover_child_scope")]
        public bool? IfCoverChildScope { get; set; }

        /// <summary>
        /// <para>预定表单开关，true表示打开，false表示关闭</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("reserve_form")]
        public bool ReserveForm { get; set; }

        /// <summary>
        /// <para>通知人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("notified_users")]
        public SubscribeUser[]? NotifiedUsers { get; set; }

        /// <summary>
        /// <para>通知人列表</para>
        /// </summary>
        public record SubscribeUser
        {
            /// <summary>
            /// <para>预定管理员ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：ou_a27b07a9071d90577c0177bcec98f856</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>最晚于会议开始前 notified_time收到通知（单位：分/时/天）</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("notified_time")]
        public int? NotifiedTime { get; set; }

        /// <summary>
        /// <para>时间单位，1为分钟；2为小时；3为天，默认为天</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("time_unit")]
        public int? TimeUnit { get; set; }
    }
}
