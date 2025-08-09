// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3GroupByGroupIdMemberBatchAddResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量添加用户组成员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 批量添加用户组成员 响应体
/// <para>调用该接口向指定的普通用户组内添加一个或多个成员。</para>
/// <para>## 注意事项</para>
/// <para>- 目前仅支持添加用户类型的成员，暂不支持添加部门类型的成员。</para>
/// <para>- 如果应用的通讯录权限范围是 **全部员工**，则可以将当前租户内的任何用户添加到任何用户组当中。如果应用的通讯录权限范围不是 **全部员工**，则所要添加的用户以及对应的用户组，均需要在应用的通讯录权限范围内。了解通讯录权限范围，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>## 使用限制</para>
/// <para>单租户内单个普通用户组的成员数量上限为 100,000。</para>
/// <para>接口ID：7106501358249852931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group-member/batch_add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup-member%2fbatch_add</para>
/// </summary>
public record PostContactV3GroupByGroupIdMemberBatchAddResponseDto
{
    /// <summary>
    /// <para>添加成员的操作结果。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("results")]
    public MemberResult[]? Results { get; set; }

    /// <summary>
    /// <para>添加成员的操作结果。</para>
    /// </summary>
    public record MemberResult
    {
        /// <summary>
        /// <para>成员 ID。ID 类型与请求参数中，每一个成员对应的 member_id_type 取值保持一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：u287xj12</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>结果响应码，取值为 `0` 表示成功。取值非 `0` 表示当前的 member_id 存在问题，具体的错误码排查方案可参考本文的错误码列表或者[通用错误码](https://open.feishu.cn/document/ukTMukTMukTM/ugjM14COyUjL4ITN)。</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
