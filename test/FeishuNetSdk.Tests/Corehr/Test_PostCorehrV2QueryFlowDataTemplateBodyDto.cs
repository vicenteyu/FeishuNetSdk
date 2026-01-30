// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-30
//
// Last Modified By : yxr
// Last Modified On : 2026-01-30
// ************************************************************************
// <copyright file="Test_PostCorehrV2QueryFlowDataTemplateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询流程数据参数模板 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询流程数据参数模板 请求体
/// <para>接口ID：7554060175772434434</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-query_flow_data_template/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-query_flow_data_template%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2QueryFlowDataTemplateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "flow_definition_id": "people_7023711013443944467_7437160904904494892",
    "variable_api_names": [
        "custome3adb7eb040.custom_field_2__c"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2QueryFlowDataTemplateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}