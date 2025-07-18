// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobFamiliesBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过序列 ID 批量获取序列信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 根据条件批量获取序列信息 响应体
/// <para>接口ID：7252157701853216796</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_family/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_family%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobFamiliesBatchGetResponseDto : TestBase
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
                "job_family_id": "4698019107896524633",
                "name": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
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
                "code": "123456",
                "description": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
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
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobFamiliesBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}