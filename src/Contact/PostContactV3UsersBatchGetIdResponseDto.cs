// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UsersBatchGetIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过手机号或邮箱获取用户 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 通过手机号或邮箱获取用户 ID 响应体
/// <para>调用该接口通过手机号或邮箱获取一个或多个用户的 ID （包括 user_id、open_id、union_id）与状态信息。</para>
/// <para>接口ID：7026591401610526724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbatch_get_id</para>
/// </summary>
public record PostContactV3UsersBatchGetIdResponseDto
{
    /// <summary>
    /// <para>手机号或者邮箱对应的用户 ID 信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_list")]
    public UserContactInfo[]? UserLists { get; set; }

    /// <summary>
    /// <para>手机号或者邮箱对应的用户 ID 信息。</para>
    /// </summary>
    public record UserContactInfo
    {
        /// <summary>
        /// <para>用户 ID，ID 类型与查询参数 user_id_type 的取值保持一致。</para>
        /// <para>例如，user_id_type 取值为 open_id，则该参数的用户 ID 值为用户的 open_id。</para>
        /// <para>不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_979112345678741d29069abcdef089d4</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>手机号，通过手机号查询时会返回该值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：13011111111</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>邮箱，通过邮箱查询时会返回该值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@z.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>用户状态。通过 is_frozen、is_resigned、is_activated、is_exited 布尔值类型参数进行展示。</para>
        /// <para>用户状态的转关逻辑可参见[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public UserStatus? Status { get; set; }

        /// <summary>
        /// <para>用户状态。通过 is_frozen、is_resigned、is_activated、is_exited 布尔值类型参数进行展示。</para>
        /// <para>用户状态的转关逻辑可参见[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)。</para>
        /// </summary>
        public record UserStatus
        {
            /// <summary>
            /// <para>是否为冻结状态。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_frozen")]
            public bool? IsFrozen { get; set; }

            /// <summary>
            /// <para>是否为离职状态。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_resigned")]
            public bool? IsResigned { get; set; }

            /// <summary>
            /// <para>是否为激活状态。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_activated")]
            public bool? IsActivated { get; set; }

            /// <summary>
            /// <para>是否为主动退出状态。主动退出一段时间后用户状态会自动转为已离职。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_exited")]
            public bool? IsExited { get; set; }

            /// <summary>
            /// <para>是否为未加入状态，需要用户自主确认才能加入企业或团队。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_unjoin")]
            public bool? IsUnjoin { get; set; }
        }
    }
}
