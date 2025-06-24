// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV2AppFeedCardResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建应用消息流卡片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 创建应用消息流卡片 响应体
/// <para>接口ID：7302258202712522780</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/app_feed_card/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fapp_feed_card%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV2AppFeedCardResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "failed_cards": [
            {
                "biz_id": "bdf22389-87ec-4890-9eb6-78a7efaeecbb",
                "user_id": "ou_88553eda9014c201e6969b478895c223",
                "reason": "NOT_CREATED"
            }
        ],
        "biz_id": "b90ce43a-fca8-4f42-92f4-794bff206ee5"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV2AppFeedCardResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}