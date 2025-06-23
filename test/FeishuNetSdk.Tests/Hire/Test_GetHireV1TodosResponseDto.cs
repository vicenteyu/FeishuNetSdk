namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 批量获取待办事项 响应体
/// <para>接口ID：7096463887449325596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/recruitment-process-follow-up/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftodo%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1TodosResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "items": [
            {
                "evaluation": {
                    "talent_id": "6891524011667228941",
                    "job_id": "6891113155221522701",
                    "application_id": "6945436033023625516",
                    "id": "6914542162822695181"
                },
                "offer": {
                    "talent_id": "6891524011667228941",
                    "job_id": "6891113155221522701",
                    "application_id": "6945436033023625516",
                    "id": "6914542162822695181"
                },
                "exam": {
                    "talent_id": "6891524011667228941",
                    "job_id": "6891113155221522701",
                    "application_id": "6945436033023625516",
                    "id": "6914542162822695181"
                },
                "interview": {
                    "talent_id": "6891524011667228941",
                    "job_id": "6891113155221522701",
                    "application_id": "6945436033023625516",
                    "id": "6914542162822695181"
                }
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1TodosResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}