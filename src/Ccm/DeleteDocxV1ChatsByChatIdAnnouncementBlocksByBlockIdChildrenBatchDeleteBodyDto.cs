// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除群公告中的块 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除群公告中的块 请求体
/// <para>指定需要操作的块，删除其指定范围的子块。如果操作成功，接口将返回应用删除操作后的群公告版本号。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的群组内。</para>
/// <para>- 操作内部群的群公告时，请确保当前调用身份（tenant_access_token 或 user_access_token）与对应群组在同一租户下。</para>
/// <para>接口ID：7450053428095598620</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/chat-announcement-block-children/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block-children%2fbatch_delete</para>
/// </summary>
public record DeleteDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenBatchDeleteBodyDto
{
    /// <summary>
    /// <para>删除的起始索引（操作区间左闭右开）</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("start_index")]
    public int StartIndex { get; set; }

    /// <summary>
    /// <para>删除的末尾索引（操作区间左闭右开）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("end_index")]
    public int EndIndex { get; set; }
}
