namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询异步任务状态 响应体
/// <para>查询删除文件夹等异步任务的状态信息。</para>
/// <para>接口ID：7094912924435021826</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/async-task/task_check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2ftask_check</para>
/// </summary>
public record GetDriveV1FilesTaskCheckResponseDto
{
    /// <summary>
    /// <para>异步任务的执行状态，如果任务执行成功则返回success，如果任务执行失败则返回fail，如果任务还在执行中则返回process。</para>
    /// <para>必填：否</para>
    /// <para>示例值：success</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
