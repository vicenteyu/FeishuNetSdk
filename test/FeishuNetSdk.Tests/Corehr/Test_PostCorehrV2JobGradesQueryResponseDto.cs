namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询职等 响应体
/// <para>接口ID：7366602835655720964</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobGradesQueryResponseDto : TestBase
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
                "job_grade_id": "4692446793125560154",
                "grade_order": 9999,
                "code": "A01234",
                "names": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "descriptions": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "active": true
            }
        ],
        "page_token": "4692446793125560154",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobGradesQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}