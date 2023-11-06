using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 上传附件 请求体
/// <para>为特定资源上传附件。本接口可以支持一次上传多个附件，最多5个。每个附件尺寸不超过50MB，格式不限。</para>
/// <para>上传请求体的格式为"form-data"。若希望上传多个附件，则提供多个"file"字段即可。返回的附件顺序将会与输入的file顺序保持一致。</para>
/// <para>目前资源类型仅支持"task", `resource_id`需要填写任务的GUID。</para>
/// <para>接口ID：7297183031634460675</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/attachment/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fattachment%2fupload</para>
/// </summary>
public record PostTaskV2AttachmentsUploadBodyDto
{
    /// <summary>
    /// <para>附件归属资源的类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：task</para>
    /// <para>默认值：task</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("resource_type")]
    public string? ResourceType { get; set; }

    /// <summary>
    /// <para>附件要归属资源的id。例如，要给任务添加附件，这里要填入任务GUID。任务GUID可以通过[任务相关接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/overview)获得。</para>
    /// <para>必填：是</para>
    /// <para>示例值：fe96108d-b004-4a47-b2f8-6886e758b3a5</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("resource_id")]
    public string ResourceId { get; set; } = string.Empty;
}
