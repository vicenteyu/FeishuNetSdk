using Newtonsoft.Json;
namespace FeishuNetSdk.PersonalSettings;
/// <summary>
/// 批量关闭系统状态 请求体
/// <para>批量关闭用户系统状态可用。</para>
/// <para>接口ID：7161608966368788483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_close</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_close</para>
/// </summary>
public record PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseBodyDto
{
    /// <summary>
    /// <para>用户ID列表，传入的ID类型由user_id_type决定，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_53edd3282dbc2fdbe5c593cfa5ce82ab</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("user_list")]
    public string[] UserList { get; set; } = Array.Empty<string>();
}
