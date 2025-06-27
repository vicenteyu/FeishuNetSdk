// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1EcoBackgroundCheckPackagesBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除背调套餐和附加调查项 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 删除背调套餐和附加调查项 请求体
/// <para>接口ID：7195815976042528770</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_package/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_package%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoBackgroundCheckPackagesBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "account_id": "6995842370159937061",
    "package_id_list": [
        "7230753910687080001"
    ],
    "additional_item_id_list": [
        "7230753910687080002"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoBackgroundCheckPackagesBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}