using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过职级 ID 批量获取职级信息 请求体
/// <para>通过职级 ID 批量获取职级信息</para>
/// <para>接口ID：7252157701853200412</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_level%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobLevelsBatchGetBodyDto
{
    /// <summary>
    /// <para>职级 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("job_level_ids")]
    public string[] JobLevelIds { get; set; } = Array.Empty<string>();
}
