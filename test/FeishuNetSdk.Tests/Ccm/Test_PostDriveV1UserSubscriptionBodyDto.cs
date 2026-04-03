// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_PostDriveV1UserSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 订阅用户云文档事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 订阅用户云文档事件 请求体
/// <para>接口ID：7623827135371201487</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/user/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fuser%2fsubscription</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1UserSubscriptionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_type": "drive.notice.comment_add_v1"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1UserSubscriptionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}