// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2WorkforcePlanDetailsBatchV2ResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询编制规划明细信息（支持自定义组织） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询编制规划明细信息（支持自定义组织） 响应体
/// <para>接口ID：7473343327586435100</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batch_v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch_v2</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2WorkforcePlanDetailsBatchV2ResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"success",
"data":{"workforce_plan_id":"7128319234123",
"centralized_reporting_project_id":"7128319234123",
"items":[{"workforce_plan_detail_id":"123456",
"dimension_info_datas":[{"dimension_key":"department",
"dimension_info":{"id":"123456",
"name":[{
    "lang": "zh-CN",
    "value": "中文示例"
}]}}],
"workforce_plan":"10.00",
"active_individuals":"10.00",
"individuals_to_be_added":"10.00",
"individuals_to_be_removed":"10.00",
"estimated_active_individuals_details":[{
    "date": "2020-10-31",
    "estimated_active_individuals": "“10.00”"
}],
"multi_period_values":[{
    "period_date": "2022-10-31",
    "workforce_plan": "12.00",
    "individuals_to_be_added": "10.00",
    "individuals_to_be_removed": "10.00"
}],
"is_missing_dimension":false,
"is_all_zero_value":false}],
"page_token":"34523459",
"has_more":true}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2WorkforcePlanDetailsBatchV2ResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}