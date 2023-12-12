namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出会议明细 响应体
/// <para>导出会议明细，具体权限要求请参考资源介绍。</para>
/// <para>接口ID：7124235806021238785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/meeting_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fmeeting_list</para>
/// </summary>
public record PostVcV1ExportsMeetingListResponseDto
{
    /// <summary>
    /// <para>任务id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7111325589855797267</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
