using Newtonsoft.Json;
namespace FeishuNetSdk.PersonalSettings;
/// <summary>
/// 批量关闭系统状态 响应体
/// <para>批量关闭用户系统状态可用。</para>
/// <para>接口ID：7161608966368788483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_close</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_close</para>
/// </summary>
public record PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseResponseDto
{
    /// <summary>
    /// <para>关闭结果</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("result_list")]
    public SystemStatusUserCloseResultEntity[] ResultLists { get; set; } = Array.Empty<SystemStatusUserCloseResultEntity>();

    /// <summary>
    /// <para>关闭结果</para>
    /// </summary>
    public record SystemStatusUserCloseResultEntity
    {
        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_53edd3282dbc2fdbe5c593cfa5ce82ab</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>关闭结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：success</para>
        /// <para>可选值：<list type="bullet">
        /// <item>success：成功</item>
        /// <item>fail：失败</item>
        /// <item>invisible_user_id：用户ID不可见</item>
        /// <item>invalid_user_id：用户ID无效</item>
        /// <item>resign_user_id：用户离职</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("result")]
        public string? Result { get; set; }
    }
}
