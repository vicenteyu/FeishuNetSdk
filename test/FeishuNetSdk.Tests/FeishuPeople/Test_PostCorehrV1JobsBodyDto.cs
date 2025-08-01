// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV1JobsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建职务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建职务 请求体
/// <para>接口ID：7017707615191040003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1JobsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": "JP422119",
    "name": [
        {
            "lang": "zh-CN",
            "value": "软件工程师"
        }
    ],
    "description": [
        {
            "lang": "zh-CN",
            "value": "负责软件系统的设计、开发与维护，参与需求分析和技术方案制定"
        }
    ],
    "active": true,
    "job_title": [
        {
            "lang": "zh-CN",
            "value": "高级软件工程师"
        }
    ],
    "pathway_id": "4719519211875096301",
    "job_family_id_list": [
        "4719519211875096301"
    ],
    "job_level_id_list": [
        "4719519212005299950"
    ],
    "working_hours_type_id": "6890452208593372679",
    "effective_time": "2020-01-01 00:00:00",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "Sandy"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1JobsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}