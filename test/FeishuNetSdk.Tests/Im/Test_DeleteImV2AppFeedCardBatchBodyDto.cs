// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteImV2AppFeedCardBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除应用消息流卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 删除应用消息流卡片 请求体
/// <para>接口ID：7302258202712490012</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/app_feed_card/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fapp_feed_card-batch%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteImV2AppFeedCardBatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "feed_cards": [
        {
            "biz_id": "ed381d34-49ac-4876-8d9e-23447acb587e",
            "user_id": "ou_88553eda9014c201e6969b478895c223"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.DeleteImV2AppFeedCardBatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}