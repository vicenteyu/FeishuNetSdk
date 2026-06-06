// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_GetOkrV2CategoriesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取所有 OKR 分类 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取所有 OKR 分类 响应体
/// <para>接口ID：7644764969658469324</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-category/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-category%2flist</para>
/// </summary>
[TestClass]
public class Test_GetOkrV2CategoriesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "items": [
            {
                "id": "7342342398472398473",
                "create_time": "1760604634563",
                "update_time": "1760604634563",
                "category_type": "person",
                "enabled": true,
                "color": "blue",
                "name": {
                    "zh": "中文",
                    "en": "英文",
                    "ja": "日文"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV2CategoriesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}