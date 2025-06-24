// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询人员调整内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询人员调整内容 请求体
/// <para>接口ID：7317581509003788292</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_job_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_job_change_list_by_ids</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "job_change_ids": [
        "6991776076699549697"
    ],
    "need_department_path": false
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}