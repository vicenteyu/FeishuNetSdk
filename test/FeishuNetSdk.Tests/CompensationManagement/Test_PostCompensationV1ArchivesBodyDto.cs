// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-10
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="Test_PostCompensationV1ArchivesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建薪资档案 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 创建薪资档案 请求体
/// <para>接口ID：7451269641491939329</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1ArchivesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "unique_id": "123e4567-e89b-42d3-a456-426614174000",
    "operator_id": "7337149697626801708",
    "user_id": "7337149697626801708",
    "effective_time": "2024-11-12",
    "currency_id": "6863329932261459464",
    "plan_id": "7431430313074247212",
    "plan_tid": "7431430313074279980",
    "change_reason_id": "7125907336899888684",
    "item_value_lists": [
        {
            "item_id": "7244131355509917228",
            "item_value": "200.00",
            "item_value_regular": "600.00"
        }
    ],
    "description": "因2024年Q2绩效优秀，对该同学调薪10%",
    "edit_remark": "更正2024年Q2绩效调薪金额"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1ArchivesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}