// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_PostCorehrV2CustomOrgEditEmpCustomOrgBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新人员自定义组织变更记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新人员自定义组织变更记录 请求体
/// <para>接口ID：7425878850969452548</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/edit_emp_custom_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fedit_emp_custom_org</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgEditEmpCustomOrgBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "00067",
    "object_api_name": "custom_org_03",
    "job_data_custom_org_id": "7293841029445207596",
    "version_id": "7293841029445207593",
    "custom_org_with_rates": [
        {
            "id": "7382048365313261588",
            "rate": "50.01"
        }
    ],
    "effective_time": "2024-06-15",
    "start_reason": "编辑雇佣信息的自定义组织"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgEditEmpCustomOrgBodyDto>(json);
        Assert.IsNotNull(result);
    }
}