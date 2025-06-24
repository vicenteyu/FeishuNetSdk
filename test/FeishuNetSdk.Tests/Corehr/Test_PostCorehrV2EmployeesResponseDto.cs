// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2EmployeesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加人员 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 添加人员 响应体
/// <para>接口ID：7350663854198161410</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employment_id": "6862995757234914824",
        "contract_id": "6862995757234914824",
        "job_data_id": "6862995757234914824"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2EmployeesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}