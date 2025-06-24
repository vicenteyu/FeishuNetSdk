namespace FeishuNetSdk.Tests.Report;

/// <summary>
/// 测试 查询任务 响应体
/// <para>接口ID：6969187588792369180</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2ftask%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostReportV1TasksQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": false,
        "items": [
            {
               "commit_time": 1622714908,
               "department_name": "",
               "department_ids": [
                    "od-189f8c99b42d3e59e7a60eff213ca387"
                ],
                "department_name": "测试部门",
                "from_user_id": "ou_c26134180ba2611aede183e5e3b531ed",
                "from_user_name": "hongyao",
                "to_user_ids": [
                    "ou_e963cfd289ae7d3e21b11ae2d8c3c604"
                ],
                "to_user_names": [
                    "gaojunqi"
                ],
                "rule_name": "report test",
                "task_id": "6969507459119693826",
                "form_contents": [
                    {
                        "field_id": "6969506834487394305",
                        "field_name": "tset info",
                        "field_value": "4567"
                    },
                    {
                        "field_id": "6969506834487410689",
                        "field_name": "number",
                        "field_value": "789768"
                    }
                ]             
            }
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Report.PostReportV1TasksQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}