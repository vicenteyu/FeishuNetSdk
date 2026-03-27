// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PostVcV1MeetingsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索会议记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 搜索会议记录 请求体
/// <para>接口ID：7621540721572694970</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostVcV1MeetingsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "周会",
    "meeting_filter": {
        "organizer_ids": [
            "ou_789012"
        ],
        "participant_ids": [
            "ou_789012"
        ],
        "open_room_ids": [
            "omm_4de32cf10a4358788ff4e09e37ebbf9b"
        ],
        "start_time": {
            "start_time": "2026-03-21T16:15:30+08:00",
            "end_time": "2026-03-21T16:15:30+08:00"
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1MeetingsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}