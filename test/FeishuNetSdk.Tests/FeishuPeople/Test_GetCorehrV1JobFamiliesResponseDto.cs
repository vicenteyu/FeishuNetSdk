// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1JobFamiliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询序列 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询序列 响应体
/// <para>接口ID：7017694651622146052</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_family%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1JobFamiliesResponseDto : TestBase
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
                "id": "4698019107896524633",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "管理序列"
                    }
                ],
                "active": true,
                "selectable": true,
                "parent_id": "4698020757495316313",
                "pathway_ids": [
                    "4719519211875096301"
                ],
                "effective_time": "2020-05-01 00:00:00",
                "expiration_time": "2020-05-02 00:00:00",
                "code": "HR-MG-001",
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "刘梓新"
                    }
                ],
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "4698019107896524634"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1JobFamiliesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}