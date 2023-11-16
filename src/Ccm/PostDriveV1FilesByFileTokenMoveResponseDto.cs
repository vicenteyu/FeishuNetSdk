namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动文件/文件夹 响应体
/// <para>将文件或者文件夹移动到用户云空间的其他位置。</para>
/// <para>接口ID：7080903916725993474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/move</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fmove</para>
/// </summary>
public record PostDriveV1FilesByFileTokenMoveResponseDto
{
    /// <summary>
    /// <para>异步任务id，移动文件夹时返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
