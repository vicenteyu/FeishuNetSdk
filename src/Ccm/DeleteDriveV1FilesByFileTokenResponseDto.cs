namespace FeishuNetSdk.Ccm;
/// <summary>
/// 删除文件/文件夹 响应体
/// <para>删除用户在云空间内的文件或者文件夹。文件或者文件夹被删除后，会进入用户回收站里。</para>
/// <para>接口ID：7029475705897828354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fdelete</para>
/// </summary>
public record DeleteDriveV1FilesByFileTokenResponseDto
{
    /// <summary>
    /// <para>异步任务id，删除文件夹时返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
