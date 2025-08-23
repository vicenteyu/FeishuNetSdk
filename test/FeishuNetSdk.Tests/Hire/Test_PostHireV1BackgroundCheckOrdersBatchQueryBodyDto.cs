// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostHireV1BackgroundCheckOrdersBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询背调信息列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询背调信息列表 请求体
/// <para>接口ID：7413697955198107652</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/background_check_order/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fbackground_check_order%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1BackgroundCheckOrdersBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "background_check_order_id_list": [
        "7412902352778840358"
    ],
    "update_start_time": "1618500000000",
    "update_end_time": "1618500278663",
    "begin_start_time": "1618500278663",
    "begin_end_time": "1618500278663",
    "application_id": "7398493486516799788",
    "order_status": "2"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1BackgroundCheckOrdersBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}