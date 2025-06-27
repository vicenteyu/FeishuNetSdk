// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHireV1EmployeesByEmployeeIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新员工状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新员工状态 响应体
/// <para>接口ID：6959374328975900674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2femployee%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1EmployeesByEmployeeIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "employee": {
            "id": "7095600054216542508",
            "application_id": "7073372582620416300",
            "onboard_status": 1,
            "conversion_status": 1,
            "onboard_time": 1637596800000,
            "expected_conversion_time": 1637596800000,
            "actual_conversion_time": 1637596800000,
            "overboard_time": 1637596800000,
            "overboard_note": "职业发展考虑",
            "onboard_city_code": "CT_2",
            "department": "6966123381141866028",
            "leader": "ou-xxx",
            "sequence": "6937934036379650311",
            "level": "7006234385490345986",
            "employee_type": "1",
            "job_requirement_id": "123123123213"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PatchHireV1EmployeesByEmployeeIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}