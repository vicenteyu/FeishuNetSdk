namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询职务 响应体
/// <para>接口ID：7017707615191023619</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1JobsResponseDto : TestBase
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
                "id": "4698040628992333549",
                "code": "JP422119",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "active": true,
                "job_title": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "job_family_id_list": [
                    "4719519211875096301"
                ],
                "job_level_id_list": [
                    "4719519212005299950"
                ],
                "working_hours_type_id": "6890452208593372679",
                "effective_time": "2020-01-01 00:00:00",
                "expiration_time": "2021-01-01 00:00:00",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1JobsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}