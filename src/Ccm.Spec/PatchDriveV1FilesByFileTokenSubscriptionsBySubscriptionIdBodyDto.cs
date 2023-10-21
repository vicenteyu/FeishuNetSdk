using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新订阅状态 请求体
/// <para>根据订阅ID更新订阅状态{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=drive&version=v1&resource=file.subscription&method=patch)</para>
/// <para>接口ID：7065964758428499996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fpatch</para>
/// </summary>
public record PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto
{
    /// <summary>
    /// <para>是否订阅</para>
    /// <para>**示例值**：true</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("is_subscribe")]
    public bool IsSubscribe { get; set; }

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
