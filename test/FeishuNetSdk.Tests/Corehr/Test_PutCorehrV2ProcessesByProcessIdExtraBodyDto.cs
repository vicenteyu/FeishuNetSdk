// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutCorehrV2ProcessesByProcessIdExtraBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 加签审批任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 加签审批任务 请求体
/// <para>接口ID：7431073872102866972</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/approver-task/update-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-extra%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCorehrV2ProcessesByProcessIdExtraBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operator": "7184703091806602796",
    "node_id": "7414045453433439788",
    "approver_id": "7424452160928106028",
    "extra_type": 1,
    "approval_type": 1,
    "extra_user_ids": [
        "7184703091806602796"
    ],
    "remark": "备注",
    "system_user": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PutCorehrV2ProcessesByProcessIdExtraBodyDto>(json);
        Assert.IsNotNull(result);
    }
}