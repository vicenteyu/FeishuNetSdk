// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1AgenciesBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索猎头供应商列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 搜索猎头供应商列表 请求体
/// <para>接口ID：7413697955198074884</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1AgenciesBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "agency_supplier_id_list": [
        "7412902352778840358"
    ],
    "keyword": "猎头",
    "filter_list": [
        {
            "key": "supplier_area",
            "value_type": 1,
            "value_list": [
                "7005471343731164709"
            ],
            "range_filter": {
                "from": "1725951088959",
                "to": "1725951088960"
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1AgenciesBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}