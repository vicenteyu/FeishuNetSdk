// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHireV1EcoBackgroundCheckPackagesBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新背调套餐和附加调查项 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新背调套餐和附加调查项 请求体
/// <para>接口ID：7195815979079548929</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_package/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_package%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1EcoBackgroundCheckPackagesBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "account_id": "6995842370159937061",
    "package_list": [
        {
            "id": "pkg001",
            "name": "基础套餐",
            "description": "工作履历信息验证X1，工作表现鉴定评价X1，教育背景核实，公民身份信息验证，简历对比，民事诉讼调查"
        }
    ],
    "additional_item_list": [
        {
            "id": "ext001",
            "name": "工作履历信息验证X2",
            "description": "详细调查"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1EcoBackgroundCheckPackagesBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}