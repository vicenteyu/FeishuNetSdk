namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除文件或文件夹 响应体
/// <para>删除用户在云空间内的文件或者文件夹。文件或文件夹被删除后，会进入回收站中。</para>
/// <para>接口ID：7029475705897828354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fdelete</para>
/// </summary>
public record DeleteDriveV1FilesByFileTokenResponseDto
{
    /// <summary>
    /// <para>异步任务 ID，删除文件夹时返回。你可继续使用[查询异步任务状态](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/task_check)接口查询任务执行状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：7360595374803812356</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
