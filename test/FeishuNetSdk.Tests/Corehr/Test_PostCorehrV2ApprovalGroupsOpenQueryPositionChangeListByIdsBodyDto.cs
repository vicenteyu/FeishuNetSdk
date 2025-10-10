// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="Test_PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询岗位调整内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询岗位调整内容 请求体
/// <para>接口ID：7428890785897234433</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_position_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_position_change_list_by_ids</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "position_change_ids": [
        "6893014062142064111"
    ],
    "need_department_path": false
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}