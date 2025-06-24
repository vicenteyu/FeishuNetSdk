// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV2BpsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 HRBP 列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取 HRBP 列表 响应体
/// <para>接口ID：7261860942295564290</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2BpsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "department_id": "4719456877659520852",
                "hrbp_id": "4719456877659520852"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2BpsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}