// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_GetDriveV1UserSubscriptionStatusResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询用户云文档事件订阅状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 查询用户云文档事件订阅状态 响应体
/// <para>接口ID：7623827135371234255</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/user/subscription_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fuser%2fsubscription_status</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1UserSubscriptionStatusResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "is_subscribe": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1UserSubscriptionStatusResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}