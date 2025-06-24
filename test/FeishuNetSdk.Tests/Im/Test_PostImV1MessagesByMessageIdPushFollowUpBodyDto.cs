// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1MessagesByMessageIdPushFollowUpBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加跟随气泡 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 添加跟随气泡 请求体
/// <para>接口ID：7377650885165268995</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v1/message/push_follow_up</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fpush_follow_up</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesByMessageIdPushFollowUpBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "follow_ups": [
        {
            "content": "你好",
            "i18n_contents": [
                {
                    "content": "hello",
                    "language": "en_us"
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesByMessageIdPushFollowUpBodyDto>(json);
        Assert.IsNotNull(result);
    }
}