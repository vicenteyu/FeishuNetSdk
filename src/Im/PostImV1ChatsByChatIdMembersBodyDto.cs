// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将用户或机器人拉入群聊 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 将用户或机器人拉入群聊 请求体
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
/// <para>- 操作同一个群组时，如果同时多次调用当前接口，可能会出现 232019 错误码，建议你串行调用，即等待当前调用完成后再进行下一次调用。</para>
/// <para>接口ID：6946222931479609345</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fcreate</para>
/// </summary>
public record PostImV1ChatsByChatIdMembersBodyDto
{
    /// <summary>
    /// <para>成员 ID 列表。</para>
    /// <para>- 邀请用户进群时推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>- 邀请机器人进群时需填写应用的 App ID，请参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：</para>
    /// <para>- 成员列表不可为空</para>
    /// <para>- 列表中填写的成员 ID 类型应与 ==member_id_type== 参数中选择的类型相对应</para>
    /// <para>- 每次请求最多拉 50 个用户且不超过群人数上限。对于已认证企业的飞书的群人数默认上限：普通群 5000 人，会议群 3000 人，话题群 5000 人。若租户管理员配置了群人数上限，则群人数上限为该人数上限</para>
    /// <para>- 最多同时邀请 5 个机器人，且邀请后群组中机器人数量不能超过 15 个</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// </summary>
    [JsonPropertyName("id_list")]
    public string[]? IdList { get; set; }
}
