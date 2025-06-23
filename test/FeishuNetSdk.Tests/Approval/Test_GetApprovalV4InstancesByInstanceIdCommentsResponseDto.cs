namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 获取评论 响应体
/// <para>接口ID：7117964632137236483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4InstancesByInstanceIdCommentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "comments": [
            {
                "id": "7081516627711524883",
                "content": "{\"text\":\"x@某某来自小程序的评论，这是一条回复\"}",
                "create_time": "1648801211000",
                "update_time": "1648801211000",
                "is_delete": 1,
                "replies": [
                    {
                        "id": "7081516611634741268",
                        "content": "{\"text\":\"x@某某来自小程序的评论，这是一条回复\"}",
                        "create_time": "1648803677000",
                        "update_time": "1648803677000",
                        "is_delete": 0,
                        "at_info_list": [
                            {
                                "user_id": "579fd9c4",
                                "name": "张某",
                                "offset": "1"
                            }
                        ],
                        "commentator": "893g4c45",
                        "extra": "{\"a\":\"a\"}"
                    }
                ],
                "at_info_list": [
                    {
                        "user_id": "579fd9c4",
                        "name": "张某",
                        "offset": "1"
                    }
                ],
                "commentator": "893g4c45",
                "extra": "{\"a\":\"a\"}"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4InstancesByInstanceIdCommentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}