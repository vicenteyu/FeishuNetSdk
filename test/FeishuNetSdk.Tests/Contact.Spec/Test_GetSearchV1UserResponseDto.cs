// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSearchV1UserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索用户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact.Spec;

/// <summary>
/// 测试 搜索用户 响应体
/// <para>接口ID：6907569524100349953</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/search-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMTM4UjLzEDO14yMxgTN</para>
/// </summary>
[TestClass]
public class Test_GetSearchV1UserResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "has_more": true,
        "page_token": "20",
        "users": [
            {
                "avatar": {
                    "avatar_72": "https://example.com/static-resource/v1/d1ca00148ad2c2cf1111~72x72.png",
                    "avatar_240": "https://example.com/static-resource/v1/d1ca00148ad2c2cf1111~240x240.png",
                    "avatar_640": "https://example.com/static-resource/v1/d1ca00148ad2c2cf1111~640x640.png",
                    "avatar_origin": "https://example.com/static-resource/v1/d1ca00148ad2c2cf1111~noop.png"
                },
                "department_ids": [
                    "od-c02cc3b682a71cdb3a4f14fc4cdb1234"
                ],
                "name": "zhangsan",
                "open_id": "ou_7d8a6e6df7621556ce0d21922b674321",
                "user_id": "02a11111"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.Spec.GetSearchV1UserResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}