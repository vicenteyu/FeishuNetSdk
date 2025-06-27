// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询部门调整内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门调整内容 请求体
/// <para>接口ID：7317581509003771908</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_department_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_department_change_list_by_ids</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_change_ids": [
        "6893014062142064111"
    ],
    "need_department_path": false
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}