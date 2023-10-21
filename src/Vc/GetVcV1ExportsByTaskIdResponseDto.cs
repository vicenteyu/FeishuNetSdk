using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询导出任务结果 响应体
/// <para>查看异步导出的进度。</para>
/// <para>接口ID：7124195547444527132</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fget</para>
/// </summary>
public record GetVcV1ExportsByTaskIdResponseDto
{
    /// <summary>
    /// <para>任务状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：3</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：处理中</item>
    /// <item>2：失败</item>
    /// <item>3：完成</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("status")]
    public int Status { get; set; }

    /// <summary>
    /// <para>文件下载地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://lf1-ttcdn-tos.pstatp.com/obj/xxx</para>
    /// </summary>
    [JsonProperty("url")]
    public string? Url { get; set; }

    /// <summary>
    /// <para>文件token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6yHu7Igp7Igy62Ez6fLr6IJz7j9i5WMe6fHq5yZeY2Jz6yLqYAMAY46fZfEz64Lr5fYyYQ==</para>
    /// </summary>
    [JsonProperty("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>失败信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：nopermission</para>
    /// </summary>
    [JsonProperty("fail_msg")]
    public string? FailMsg { get; set; }
}
