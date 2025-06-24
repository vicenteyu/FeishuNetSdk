// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHireV1EmployeesByEmployeeIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新员工状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新员工状态 请求体
/// <para>接口ID：6959374328975900674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2femployee%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1EmployeesByEmployeeIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operation": 1,
    "conversion_info": {
        "actual_conversion_time": 1637596800000
    },
    "overboard_info": {
        "actual_overboard_time": 1637596800000,
        "overboard_note": "职业发展考虑"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1EmployeesByEmployeeIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}