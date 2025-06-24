// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1OfferSchemasByOfferSchemaIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 Offer 申请表详细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire.Spec;

/// <summary>
/// 测试 获取 Offer 申请表详细信息 响应体
/// <para>接口ID：6964286393804881948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/hire_internal/offer/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_schema%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1OfferSchemasByOfferSchemaIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id": "1213213123123",
        "scenario": 1,
        "version": 121,
        "object_list": [
            {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "名字",
                    "en_us": "name"
                },
                "type": "number",
                "is_customized": true,
                "option_list": [
                    {
                        "name": {
                            "zh_cn": "名字",
                            "en_us": "name"
                        },
                        "index": 121,
                        "active_status": 1
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.Spec.GetHireV1OfferSchemasByOfferSchemaIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}