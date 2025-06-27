// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新外部背调 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新外部背调 请求体
/// <para>接口ID：7407298680640929795</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-background-info/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_background_check%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_application_id": "7003247299220982060",
    "date": 1626602069393,
    "name": "张三的背调",
    "result": "已通过",
    "attachment_id_list": [
        "7003247299220982060"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1ExternalBackgroundChecksByExternalBackgroundCheckIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}