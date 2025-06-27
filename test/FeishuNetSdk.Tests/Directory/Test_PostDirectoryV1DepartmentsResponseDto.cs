// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1DepartmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 创建部门 响应体
/// <para>接口ID：7359428154233536516</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1DepartmentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "department_id": "eesdasd"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.PostDirectoryV1DepartmentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}