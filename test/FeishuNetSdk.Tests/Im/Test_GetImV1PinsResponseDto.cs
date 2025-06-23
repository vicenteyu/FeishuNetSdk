namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取群内 Pin 消息 响应体
/// <para>接口ID：7138313270488891394</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2flist</para>
/// </summary>
[TestClass]
public class Test_GetImV1PinsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "message_id": "om_dc13264520392913993dd051dba2123",
                "chat_id": "oc_a0553eda9014c201e6969b478895123",
                "operator_id": "ou_7d8a6e6df7621556ce0d21922b6767123",
                "operator_id_type": "open_id",
                "create_time": "1615380573211"
            }
        ],
        "has_more": true,
        "page_token": "GxmvlNRvP0NdQZpa7yIqf_Lv_QuBwTQ8tXkX7w-irAghVD_TvuYd1aoJ1LQph86O-XImC4X9j9FhU123=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1PinsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}