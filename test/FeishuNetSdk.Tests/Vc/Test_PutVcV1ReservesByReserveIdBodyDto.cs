namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 更新预约 请求体
/// <para>接口ID：6921909217674854427</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutVcV1ReservesByReserveIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "end_time": "1608888867",
    "meeting_settings": {
        "topic": "my meeting",
        "action_permissions": [
            {
                "permission": 1,
                "permission_checkers": [
                    {
                        "check_field": 1,
                        "check_mode": 1,
                        "check_list": [
                            "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
                        ]
                    }
                ]
            }
        ],
        "meeting_initial_type": 1,
        "meeting_connect": true,
        "call_setting": {
            "callee": {
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                "user_type": 1,
                "pstn_sip_info": {
                    "nickname": "dodo",
                    "main_address": "+86-02187654321"
                }
            }
        },
        "auto_record": true,
        "assign_host_list": [
            {
                "user_type": 1,
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
            }
        ],
        "password": "971024"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PutVcV1ReservesByReserveIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}