// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV1ChatsByChatIdAnnouncementBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新群公告信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新群公告信息 请求体
/// <para>更新指定群组中的群公告信息。更新的公告内容格式和更新[旧版云文档](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)的格式相同，不支持新版云文档格式。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的群组内，且需要拥有群公告文档的阅读权限。</para>
/// <para>## 使用限制</para>
/// <para>- 如果群组配置了 **仅群主和群管理员可编辑群信息**，则仅有群主、群管理员，或者是创建群组且具有 **更新应用所创建群的群信息（im:chat:operate_as_owner）** 权限的机器人，可以更新群公告信息。</para>
/// <para>- 如果群组没有配置 **仅群主和群管理员可编辑群信息**，则所有群成员可以更新群公告信息。</para>
/// <para>- 操作内部群时，操作者和被操作的群组必须在同一租户下。</para>
/// <para>接口ID：6946222931479511041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-announcement/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-announcement%2fpatch</para>
/// </summary>
public record PatchImV1ChatsByChatIdAnnouncementBodyDto
{
    /// <summary>
    /// <para>文档当前版本号 int64 类型，可调用[获取群公告信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-announcement/get)接口，从返回结果中获取。</para>
    /// <para>**注意**：传入的版本号和最新版本号的差距不能超过 100。</para>
    /// <para>必填：是</para>
    /// <para>示例值：12</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; } = string.Empty;

    /// <summary>
    /// <para>公告内容，调用接口时该参数必须传入值。公告内容的格式与更新旧版文档内容的格式相同，具体数据结构参考[编辑旧版文档内容](https://open.feishu.cn/document/ukTMukTMukTM/uYDM2YjL2AjN24iNwYjN)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"requestType\":\"InsertBlocksRequestType\",\"insertBlocksRequest\":{\"payload\":\"{\\\"blocks\\\":[{\\\"type\\\":\\\"paragraph\\\",\\\"paragraph\\\":{\\\"elements\\\":[{\\\"type\\\":\\\"textRun\\\",\\\"textRun\\\":{\\\"text\\\":\\\"ylyyyyyDocs API Sample Content\\\",\\\"style\\\":{}}}],\\\"style\\\":{}}}]}\",\"location\":{\"zoneId\":\"0\",\"index\":0, \"endOfZone\": true}}}</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public string[]? Requests { get; set; }
}
