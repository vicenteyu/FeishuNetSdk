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
/// <para>把指定的用户或机器人拉入指定群聊内。</para>
/// <para>## 前提条件</para>
/// <para>- 调用该接口的应用，需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用该接口的应用或者用户，必须在相应的群组中。</para>
/// <para>- 如需拉机器人进群，则该机器人必须开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 如果以应用身份拉用户进群，则该用户需要在应用的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。</para>
/// <para>## 使用限制</para>
/// <para>- 外部租户不能被拉入内部群，但可以被拉入外部群。通过机器人拉外部租户的用户进群，需要先为机器人配置对外共享能力，详情参考[机器人支持外部群和外部用户单聊](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/develop-robots/add-bot-to-external-group)。</para>
/// <para>- 操作内部群时，当前操作者必须与群组在同一租户内。</para>
/// <para>- 如果群组配置了 **仅群主和群管理员可添加群成员**，则仅有群主、群管理员，或者是创建群组且具有 **更新应用所创建群的群信息（im:chat:operate_as_owner）** 权限的机器人，可以拉用户或机器人进群。</para>
/// <para>- 如果群组没有配置 **仅群主和群管理员可添加群成员**，则所有群成员都可以拉用户或机器人进群。</para>
/// <para>接口ID：6946222931479609345</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fcreate</para>
/// </summary>
public record PostImV1ChatsByChatIdMembersResponseDto
{
    /// <summary>
    /// <para>无效成员列表</para>
    /// <para>**注意**：</para>
    /// <para>- 当`success_type` 取值为 `0`时，`invalid_id_list`只包含已离职的用户ID</para>
    /// <para>- 当`success_type` 取值为 `1`时，`invalid_id_list`中包含已离职的、不可见的、应用未激活的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_id_list")]
    public string[]? InvalidIdList { get; set; }

    /// <summary>
    /// <para>ID 不存在的成员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("not_existed_id_list")]
    public string[]? NotExistedIdList { get; set; }

    /// <summary>
    /// <para>等待群主或管理员审批的成员 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pending_approval_id_list")]
    public string[]? PendingApprovalIdList { get; set; }
}
