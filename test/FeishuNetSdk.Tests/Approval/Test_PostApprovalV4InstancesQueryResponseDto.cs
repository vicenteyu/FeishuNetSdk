namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 查询实例列表 响应体
/// <para>接口ID：7117964632137203715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "count": 10,
        "instance_list": [
            {
                "approval": {
                    "code": "EB828003-9FFE-4B3F-AA50-2E199E2ED943",
                    "name": "approval",
                    "is_external": true,
                    "external": {
                        "batch_cc_read": false
                    },
                    "approval_id": "7090754740375519252",
                    "icon": "https://lf3-ea.bytetos.com/obj/goofy/ee/approval/approval-admin/image/iconLib/v3/person.png"
                },
                "group": {
                    "external_id": "0004",
                    "name": "groupA"
                },
                "instance": {
                    "code": "EB828003-9FFE-4B3F-AA50-2E199E2ED943",
                    "external_id": "0004_3ED52DC1-AA6C",
                    "user_id": "lwiu098wj",
                    "start_time": "1547654251506",
                    "end_time": "1547654251506",
                    "status": "pending",
                    "title": "test",
                    "extra": "{}",
                    "serial_id": "201902020001",
                    "link": {
                        "pc_link": "https://www.example.com/",
                        "mobile_link": "https://www.example.com/"
                    }
                }
            }
        ],
        "page_token": "nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4InstancesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}