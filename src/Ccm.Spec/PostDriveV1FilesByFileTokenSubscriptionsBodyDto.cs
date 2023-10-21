using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建订阅 请求体
/// <para>订阅文档中的变更事件，当前支持文档评论订阅，订阅后文档评论更新会有“云文档助手”推送给订阅的用户{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=drive&version=v1&resource=file.subscription&method=create)</para>
/// <para>接口ID：7065964758428483612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fcreate</para>
/// </summary>
public record PostDriveV1FilesByFileTokenSubscriptionsBodyDto
{
    /// <summary>
    /// <para>订阅关系ID</para>
    /// <para>**示例值**："1234567890987654321"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("subscription_id")]
    public string? SubscriptionId { get; set; }

    /// <summary>
    /// <para>订阅类型</para>
    /// <para>**示例值**："comment_update"</para>
    /// <para>**可选值有**：</para>
    /// <para>comment_update:评论更新</para>
    /// <para>必填：是</para>
    /// <para>可选值：<list type="bullet">
    /// <item>comment_update：评论更新</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("subscription_type")]
    public string SubscriptionType { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否订阅</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("is_subcribe")]
    public bool? IsSubcribe { get; set; }

    /// <summary>
    /// <para>文档类型</para>
    /// <para>**示例值**："doc"</para>
    /// <para>**可选值有**：</para>
    /// <para>doc:文档,docx:新版文档,wiki:知识库wiki</para>
    /// <para>必填：是</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：文档</item>
    /// <item>docx：新版文档</item>
    /// <item>wiki：知识库wiki</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("file_type")]
    public string FileType { get; set; } = string.Empty;
}
