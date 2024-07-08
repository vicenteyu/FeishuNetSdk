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
        /// <para>结果响应码，取值为 `0` 表示成功。</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
