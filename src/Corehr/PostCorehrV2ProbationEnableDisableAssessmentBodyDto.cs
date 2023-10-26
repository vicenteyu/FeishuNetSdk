using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 启用/停用试用期考核功能 请求体
/// <para>启用/停用试用期考核功能，启用后系统功能中针对试用期考核相关的字段会自动启用，并可通过接口更新试用期考核结果</para>
/// <para>接口ID：7254814386694569986</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/probation/enable_disable_assessment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fenable_disable_assessment</para>
/// </summary>
public record PostCorehrV2ProbationEnableDisableAssessmentBodyDto
{
    /// <summary>
    /// <para>启用 / 停用状态。启用后可在试用期管理页面中可见试用期考核相关的字段。</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("active")]
    public bool Active { get; set; }

    /// <summary>
    /// <para>试用期考核系统入口链接，当启用功能时该字段必填。</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://qwe111.feishuapp.bytedance.net/ae/ui/apps/176612345027111/appPages/l11bsrwss13yt?dataGrid%41pye4fsbajo21l=%7B%7D&amp;key=ffm41o1&amp;dataGrid%41wmv98t29vif3kj=%1B%7D</para>
    /// </summary>
    [JsonProperty("app_url")]
    public string? AppUrl { get; set; }
}
