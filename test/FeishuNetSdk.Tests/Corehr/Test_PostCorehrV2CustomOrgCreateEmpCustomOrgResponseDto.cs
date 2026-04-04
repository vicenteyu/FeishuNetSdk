// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_PostCorehrV2CustomOrgCreateEmpCustomOrgResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增人员自定义组织变更记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 新增人员自定义组织变更记录 响应体
/// <para>接口ID：7425878850969403396</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/employee-custom_org/create_emp_custom_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee-custom_org%2fcreate_emp_custom_org</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgCreateEmpCustomOrgResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_data_custom_org_id": "7293841029445207596",
        "version_id": "7293841029445207593"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgCreateEmpCustomOrgResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}