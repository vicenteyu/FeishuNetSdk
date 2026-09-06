// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_PostVcV1BotsJoinBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 加入会议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 加入会议 请求体
/// <para>接口ID：7672664994767015159</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/join</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fjoin</para>
/// </summary>
[TestClass]
public class Test_PostVcV1BotsJoinBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "join_type": 1,
    "join_identify": {
        "meeting_no": "123456789"
    },
    "password": "******",
    "call_id": "7c9e6679-7425-40de-944b-e07fc1f90ae7"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1BotsJoinBodyDto>(json);
        Assert.IsNotNull(result);
    }
}