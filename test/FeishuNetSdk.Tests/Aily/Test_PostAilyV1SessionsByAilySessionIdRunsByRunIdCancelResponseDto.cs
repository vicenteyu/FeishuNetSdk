namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 取消运行 响应体
/// <para>接口ID：7358047310868217860</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-run/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-run%2fcancel</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "run": {
            "id": "run_4dfrxvctjqzzj",
            "created_at": "1711975665710",
            "app_id": "spring_xxx__c",
            "session_id": "session_4dfunz7sp1g8m",
            "status": "IN_PROGRESS",
            "started_at": "1711975665710",
            "ended_at": "1711975665710",
            "error": {
                "code": "sp_ec_sm_900101",
                "message": "技能不存在或已删除"
            },
            "metadata": "{}"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}