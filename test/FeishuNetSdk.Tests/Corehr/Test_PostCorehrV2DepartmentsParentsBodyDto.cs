// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2DepartmentsParentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取父部门信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取父部门信息 请求体
/// <para>接口ID：7236202966714957826</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/parents</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fparents</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsParentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_id_list": [
        "6893014062142064111"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsParentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}