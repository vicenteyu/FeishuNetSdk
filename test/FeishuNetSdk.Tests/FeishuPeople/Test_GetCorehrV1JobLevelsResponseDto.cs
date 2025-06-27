// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1JobLevelsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询职级 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询职级 响应体
/// <para>接口ID：7017694651622162436</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_level%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1JobLevelsResponseDto : TestBase
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
                "id": "4692446793125560154",
                "level_order": 9999,
                "code": "VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=",
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
                "custom_fields": [
                    {
                        "field_name": "自定义字段 API Name，即自定义字段的唯一标识",
                        "value": "\"Sandy\""
                    }
                ],
                "job_grade": [
                    "4692446793125560154"
                ],
                "pathway_ids": [
                    "4719519211875096301"
                ]
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1JobLevelsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}