// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobLevelsBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过职级 ID 批量获取职级信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 通过职级 ID 批量获取职级信息 响应体
/// <para>接口ID：7252157701853200412</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_level/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_level%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobLevelsBatchGetResponseDto : TestBase
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
                "job_level_id": "4692446793125560154",
                "level_order": 9999,
                "code": "VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "active": true,
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ],
                "job_grade": [
                    "4692446793125560154"
                ],
                "pathway_ids": [
                    "4719519211875096301"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobLevelsBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}