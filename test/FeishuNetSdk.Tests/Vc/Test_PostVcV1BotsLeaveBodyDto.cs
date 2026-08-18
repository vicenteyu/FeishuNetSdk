// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="Test_PostVcV1BotsLeaveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 离开会议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 离开会议 请求体
/// <para>接口ID：7672664994766998775</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/leave</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fleave</para>
/// </summary>
[TestClass]
public class Test_PostVcV1BotsLeaveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "meeting_id": "mtg_202405201430_001"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1BotsLeaveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}