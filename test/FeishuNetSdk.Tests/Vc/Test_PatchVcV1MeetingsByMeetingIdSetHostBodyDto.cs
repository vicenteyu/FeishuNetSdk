// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchVcV1MeetingsByMeetingIdSetHostBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设置主持人 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 设置主持人 请求体
/// <para>接口ID：6921909217674805275</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/set_host</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fset_host</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1MeetingsByMeetingIdSetHostBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "host_user": {
        "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
        "user_type": 1
    },
    "old_host_user": {
        "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
        "user_type": 1
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1MeetingsByMeetingIdSetHostBodyDto>(json);
        Assert.IsNotNull(result);
    }
}