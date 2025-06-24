// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1MeetingsByMeetingIdRecordingResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取录制文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取录制文件 响应体
/// <para>接口ID：6960861158593101828</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-recording/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting-recording%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1MeetingsByMeetingIdRecordingResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "recording": {
            "url": "https://meetings.feishu.cn/minutes/obcn37dxcftoc3656rgyejm7",
            "duration": "30000"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1MeetingsByMeetingIdRecordingResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}