namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新 e-HR 导入任务结果 请求体
/// <para>在处理完导入 e-HR 事件后，可调用该接口，更新 e-HR 导入任务结果。</para>
/// <para>接口ID：6992933256561426436</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fehr_import_task%2fpatch</para>
/// </summary>
public record PatchHireV1EhrImportTasksByEhrImportTaskIdBodyDto
{
    /// <summary>
    /// <para>失败原因，仅在导入结果为失败时可用</para>
    /// <para>必填：否</para>
    /// <para>示例值：当前HC不可用</para>
    /// </summary>
    [JsonPropertyName("fail_reason")]
    public string? FailReason { get; set; }

    /// <summary>
    /// <para>跳转链接，若需返回跳转链接，请前往飞书招聘「设置 - 生态对接 - e-HR / OA 办公系统 - 『导入 e-HR』功能设置」中开启「支持对接的 e-HR / OA 系统返回外部链接」开关</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://example.com</para>
    /// </summary>
    [JsonPropertyName("redirect_url")]
    public string? RedirectUrl { get; set; }

    /// <summary>
    /// <para>导入结果</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：导入成功</item>
    /// <item>2：导入失败</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("state")]
    public int State { get; set; }
}
