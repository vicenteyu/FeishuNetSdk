namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新消息流卡片按钮 响应体
/// <para>接口ID：7302258202712506396</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat_button%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV2ChatButtonResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "failed_user_reasons": [
            {
                "error_code": 0,
                "error_message": "The user is not in the chat",
                "user_id": "ou_679eaeb583654bff73fefcc6e6371301"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PutImV2ChatButtonResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}