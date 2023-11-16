namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出参会人会议质量数据 响应体
/// <para>导出某场会议某个参会人的音视频&amp;共享质量数据</para>
/// <para>（仅支持已结束会议），具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7124195547444494364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/participant_quality_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fparticipant_quality_list</para>
/// </summary>
public record PostVcV1ExportsParticipantQualityListResponseDto
{
    /// <summary>
    /// <para>任务id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7111325589855797267</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
