using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出会议室预定数据 响应体
/// <para>导出会议室预定数据，具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7124195547444510748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/resource_reservation_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fresource_reservation_list</para>
/// </summary>
public record PostVcV1ExportsResourceReservationListResponseDto
{
    /// <summary>
    /// <para>任务id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7111325589855797267</para>
    /// </summary>
    [JsonProperty("task_id")]
    public string? TaskId { get; set; }
}
