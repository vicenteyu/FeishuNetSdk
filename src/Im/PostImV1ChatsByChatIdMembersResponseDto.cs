// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将用户或机器人拉入群聊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 将用户或机器人拉入群聊 响应体
/// <para>将用户或机器人拉入群聊。</para>
/// <para>接口ID：6946222931479609345</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fcreate</para>
/// </summary>
public record PostImV1ChatsByChatIdMembersResponseDto
{
    /// <summary>
    /// <para>无效成员列表</para>
    /// <para>**注意**：</para>
    /// <para>- 当`success_type=0`时，`invalid_id_list`只包含已离职的用户ID</para>
    /// <para>- 当`success_type=1`时，`invalid_id_list`中包含已离职的、不可见的、应用未激活的ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_id_list")]
    public string[]? InvalidIdList { get; set; }

    /// <summary>
    /// <para>ID不存在的成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("not_existed_id_list")]
    public string[]? NotExistedIdList { get; set; }

    /// <summary>
    /// <para>等待群主或管理员审批的成员ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pending_approval_id_list")]
    public string[]? PendingApprovalIdList { get; set; }
}
