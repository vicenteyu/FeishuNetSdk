// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostApprovalV1MessageUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新审批 Bot 消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 更新审批 Bot 消息 请求体
/// <para>调用[发送审批 Bot 消息](https://open.feishu.cn/document/ukTMukTMukTM/ugDNyYjL4QjM24CO0IjN)接口后，可根据审批 Bot 消息 ID 及审批相应的状态，更新审批 Bot 消息。例如，给审批人推送了审批待办消息，当审批人通过审批后，可以将之前推送的 Bot 消息更新为已审批。</para>
/// <para>使用限制：</para>
/// <para>- 只能更新审批状态，以及审批同意或拒绝后的标题或者查看详情的文案。</para>
/// <para>- 只能更新模板为 1008「收到审批待办」的卡片。</para>
/// <para>- 只支持更新 30 天以内的审批 bot 消息。</para>
/// <para>接口ID：6907569743419752450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/update-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNyYjLwYjM24CM2IjN</para>
/// </summary>
public record PostApprovalV1MessageUpdateBodyDto
{
    /// <summary>
    /// <para>待更新的审批 Bot 消息 ID。调用[发送审批 Bot 消息](https://open.feishu.cn/document/ukTMukTMukTM/ugDNyYjL4QjM24CO0IjN)接口后，从返回结果中获取消息 ID。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;

    /// <summary>
    /// <para>状态类型，用于更新消息内第一个 `action` 的文字内容。可选值有：</para>
    /// <para>- APPROVED：已同意</para>
    /// <para>- REJECTED：已拒绝</para>
    /// <para>- CANCELLED：已撤回</para>
    /// <para>- FORWARDED：已转交</para>
    /// <para>- ROLLBACK：已回退</para>
    /// <para>- ADD：已加签</para>
    /// <para>- DELETED：已删除</para>
    /// <para>- PROCESSED：已处理</para>
    /// <para>- CUSTOM：自定义按钮状态</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>当 status 取值 CUSTOM 时，可以自定义审批同意或拒绝后 title 内容。</para>
    /// <para>**注意**:</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key：Value 格式进行赋值。</para>
    /// <para>- Key 需要以 `@i18n@` 开头。</para>
    /// <para>**示例值**：@i18n@1</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status_name")]
    public string? StatusName { get; set; }

    /// <summary>
    /// <para>当 status 取值 CUSTOM 时，可以自定义审批同意或拒绝后 **查看详情** 按钮名称。</para>
    /// <para>**注意**:</para>
    /// <para>- 这里传入的是国际化文案 Key（即 i18n_resources.texts 参数中的 Key），还需要在 i18n_resources.texts 参数中以 Key：Value 格式进行赋值。</para>
    /// <para>- Key 需要以 `@i18n@` 开头。</para>
    /// <para>**示例值**：@i18n@2</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("detail_action_name")]
    public string? DetailActionName { get; set; }

    /// <summary>
    /// <para>国际化文案。status_name、detail_action_name 参数设置了国际化文案 Key 后，需要通过 i18n_resources 设置 Key：value 关系为参数赋值。</para>
    /// <para>例如，status_name取值为 @i18n@1，则需要在 i18n_resources.texts 中传入 `@i18n@1： 已废弃` 为参数赋值。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("i18n_resources")]
    public I18nResource[]? I18nResources { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record I18nResource
    {
        /// <summary>
        /// <para>语言。可选值有：</para>
        /// <para>- zh-CN：中文</para>
        /// <para>- en-US：英文</para>
        /// <para>- ja-JP：日文</para>
        /// <para>**示例值**：zh-CN</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; } = string.Empty;

        /// <summary>
        /// <para>当前语言是否为默认语言。默认语言需要在 texts 中传入所有的 Key：Value，非默认语言如果缺失 Key，则会使用默认语言代替。</para>
        /// <para>**示例值**：true</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// <para>文案的 Key:Value。Key 需要以 `@i18n@` 开头，并按照各个参数的要求传入 Value。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("texts")]
        public Dictionary<string, object?> Texts { get; set; } = [];
    }
}
