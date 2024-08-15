// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3UsersByUserIdUpdateUserIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新用户ID 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新用户 ID 请求体
/// <para>调用该接口更新用户的 user_id。</para>
/// <para>## 注意事项</para>
/// <para>更新后的用户 user_id 需要保证在当前租户内未被占用。</para>
/// <para>接口ID：7257363132833300482</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/update_user_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fupdate_user_id</para>
/// </summary>
public record PatchContactV3UsersByUserIdUpdateUserIdBodyDto
{
    /// <summary>
    /// <para>自定义新的用户 user_id。长度不能超过 64 字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：3e3cf96b</para>
    /// </summary>
    [JsonPropertyName("new_user_id")]
    public string NewUserId { get; set; } = string.Empty;
}
