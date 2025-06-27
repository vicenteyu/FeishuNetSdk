// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostVcV1MeetingsByMeetingIdKickoutBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 移除参会人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 移除参会人 请求体
/// <para>接口ID：6997003722790633474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/kickout</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fkickout</para>
/// </summary>
[TestClass]
public class Test_PostVcV1MeetingsByMeetingIdKickoutBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "kickout_users": [
        {
            "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
            "user_type": 1
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1MeetingsByMeetingIdKickoutBodyDto>(json);
        Assert.IsNotNull(result);
    }
}