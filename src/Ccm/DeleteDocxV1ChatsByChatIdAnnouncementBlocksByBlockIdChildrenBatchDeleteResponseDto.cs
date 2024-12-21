// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除群公告中的块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除群公告中的块 响应体
/// <para>指定需要操作的块，删除其指定范围的子块。如果操作成功，接口将返回应用删除操作后的群公告版本号。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的群组内。</para>
/// <para>- 操作内部群的群公告时，请确保当前调用身份（tenant_access_token 或 user_access_token）与对应群组在同一租户下。</para>
/// <para>接口ID：7450053428095598620</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/chat-announcement-block-children/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block-children%2fbatch_delete</para>
/// </summary>
public record DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteResponseDto
{
    /// <summary>
    /// <para>当前删除操作成功后群公告的版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("revision_id")]
    public int? RevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }
}
