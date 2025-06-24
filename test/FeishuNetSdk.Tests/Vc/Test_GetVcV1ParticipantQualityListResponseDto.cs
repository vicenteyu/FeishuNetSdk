// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ParticipantQualityListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询参会人会议质量数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询参会人会议质量数据 响应体
/// <para>接口ID：7194805625628049411</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fparticipant_quality_list%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ParticipantQualityListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "participant_quality_list": [
            {
                "network": {
                    "time": "2022.12.23 11:16:00 (GMT+08:00)",
                    "network_delay": "100ms",
                    "bitrate_received": "8kbps",
                    "packet_loss_avg_received": "8%",
                    "packet_loss_max_received": "9%",
                    "bitrate_sent": "9kbps",
                    "packet_loss_avg_sent": "8%",
                    "packet_loss_max_sent": "10%"
                },
                "audio": {
                    "time": "2022.12.23 11:16:00 (GMT+08:00)",
                    "mic_input_volume": "6dB",
                    "speaker_volume": "8dB",
                    "bitrate_received": "3kbps",
                    "latency_received": "100ms",
                    "jitter_received": "100ms",
                    "bitrate_sent": "9kbps",
                    "latency_sent": "100ms",
                    "jitter_sent": "100ms"
                },
                "video": {
                    "time": "2022.12.23 11:16:00 (GMT+08:00)",
                    "bitrate_received": "8kbps",
                    "latency_received": "100ms",
                    "jitter_received": "100ms",
                    "maximum_resolution_received": "1080P",
                    "framerate_received": "100fps",
                    "bitrate_sent": "9kbps",
                    "latency_sent": "100ms",
                    "jitter_sent": "100ms",
                    "maximum_resolution_sent": "4K",
                    "framerate_sent": "90fps"
                },
                "screen_sharing": {
                    "time": "2022.12.23 11:16:00 (GMT+08:00)",
                    "bitrate_received": "8kbps",
                    "latency_received": "100ms",
                    "jitter_received": "100ms",
                    "maximum_resolution_received": "1080P",
                    "framerate_received": "100fps",
                    "bitrate_sent": "9kbps",
                    "latency_sent": "100ms",
                    "jitter_sent": "100ms",
                    "maximum_resolution_sent": "4K",
                    "framerate_sent": "90fps"
                },
                "cpu_usage": {
                    "time": "2022.12.23 11:17:00",
                    "client_avg_cpu_usage": "0.8%",
                    "client_max_cpu_usage": "2.3%",
                    "system_avg_cpu_usage": "8.3%",
                    "system_max_cpu_usage": "30%"
                }
            }
        ],
        "page_token": "20",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ParticipantQualityListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}