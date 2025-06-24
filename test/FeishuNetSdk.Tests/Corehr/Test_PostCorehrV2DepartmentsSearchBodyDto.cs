// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2DepartmentsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索部门信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索部门信息 请求体
/// <para>接口ID：7211423970042200068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "active": true,
    "get_all_children": false,
    "manager_list": [
        "7094136522860922112"
    ],
    "department_id_list": [
        "7094136522860922111"
    ],
    "name_list": [
        "后端研发部"
    ],
    "parent_department_id": "7094136522860922222",
    "code_list": [
        "D00000123"
    ],
    "fields": [
        "department_name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}