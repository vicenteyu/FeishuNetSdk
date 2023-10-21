using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增视图 请求体
/// <para>在数据表中新增一个视图</para>
/// <para>接口ID：6978670625209614338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdViewsBodyDto
{
    /// <summary>
    /// <para>视图名字</para>
    /// <para>必填：是</para>
    /// <para>示例值：表格视图1</para>
    /// </summary>
    [JsonProperty("view_name")]
    public string ViewName { get; set; } = string.Empty;

    /// <summary>
    /// <para>视图类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：grid</para>
    /// <para>可选值：<list type="bullet">
    /// <item>grid：表格视图</item>
    /// <item>kanban：看板视图</item>
    /// <item>gallery：画册视图</item>
    /// <item>gantt：甘特视图</item>
    /// <item>form：表单视图</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("view_type")]
    public string? ViewType { get; set; }
}
