// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1AgenciesByAgencyIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取猎头供应商信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取猎头供应商信息 响应体
/// <para>接口ID：6965472560995057666</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/agency/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1AgenciesByAgencyIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "agency": {
            "id": "6898173495386147079",
            "name": "超越猎头公司",
            "contactor_id": "ou_f476cb099ac9227c9bae09ce46112579",
            "contactor_name": {
                "zh_cn": "张三",
                "en_us": "zhangsan"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1AgenciesByAgencyIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}