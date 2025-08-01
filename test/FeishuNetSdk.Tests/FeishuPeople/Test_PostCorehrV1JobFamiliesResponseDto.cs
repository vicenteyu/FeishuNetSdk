// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1JobFamiliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建序列 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建序列 响应体
/// <para>接口ID：7017707615190925315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_family%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1JobFamiliesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_family": {
            "id": "4698019107896524633",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "张三"
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
                    "value": "这是一个技术序列的描述"
                }
            ],
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1JobFamiliesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}