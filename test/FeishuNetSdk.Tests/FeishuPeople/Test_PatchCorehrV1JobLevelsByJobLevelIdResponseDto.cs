// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV1JobLevelsByJobLevelIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新单个职级 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新单个职级 响应体
/// <para>接口ID：7072714700206768130</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_level%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1JobLevelsByJobLevelIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_level": {
            "id": "4692446793125560154",
            "level_order": 10,
            "code": "J001",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "P5"
                }
            ],
            "description": [
                {
                    "lang": "zh-CN",
                    "value": "普通职级"
                }
            ],
            "active": true,
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"工程师\""
                }
            ],
            "job_grade": [
                "4692446793125560154"
            ],
            "pathway_ids": [
                "4719519211875096301"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PatchCorehrV1JobLevelsByJobLevelIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}